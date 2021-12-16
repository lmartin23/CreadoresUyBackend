﻿using Application.Interface;
using Application.Service;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Share;
using Share.Dtos;
using Share.Entities;
using Share.NoSql;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApi.Models;

namespace Application.Features.UserFeatures.Queries
{
    public class GetLogingUserQuery : IRequest<Response<AuthenticateResponse>>
    {
        public LoginDto User { get; set; }


        public class GetLogingUserHandler : IRequestHandler<GetLogingUserQuery, Response<AuthenticateResponse>>
        {

            private readonly ICreadoresUyDbContext _context;

            private readonly IMapper _mapper;

            private readonly NoSQLConnection _noSQLConnection;

            
            public GetLogingUserHandler(ICreadoresUyDbContext context, IMapper imapper, NoSQLConnection nosql)
            {
                _context = context;
                _mapper = imapper;
                _noSQLConnection = nosql;
            }
            public async Task<Response<AuthenticateResponse>> Handle(GetLogingUserQuery query, CancellationToken cancellationToken)
            {

                var u = _mapper.Map<User>(query.User);
                var user = await _context.Users.Where(x => (x.Email == u.Email && x.Password == u.Password)).FirstOrDefaultAsync();
                

                var nickname = "";
                Response<AuthenticateResponse> res = new Response<AuthenticateResponse>();
                res.Message = new List<string>();

                if (user == null)
                {

                    res.CodStatus = HttpStatusCode.BadRequest;
                    res.Success = false;
                    res.Message.Add("Contraseña o email erroneos");

                    _noSQLConnection.Create(new LogDto(u.Email,false,DateTime.Now));

                    return res;

                }

                if (user.CreatorId != null)
                {
                    var creador = await _context.Creators.Where(x => x.Id == user.CreatorId).FirstOrDefaultAsync();
                    nickname = creador.NickName;
                }



                var claims = new List<Claim>();
                claims.Add(new Claim("username", user.Name));
                claims.Add(new Claim("displayname", user.Name));

                // Add roles as multiple claims

                var rol = "user";

                if (user.CreatorId != null)
                {
                    rol = "creator";
                }
                if (user.IsAdmin == true)
                {
                    rol = "admin";
                }

                {
                    claims.Add(new Claim(ClaimTypes.Role, rol));


                    // create a new token with token helper and add our claim
                    // from `Westwind.AspNetCore`  NuGet Package
                    var token = JwtHelper.GetJwtToken(
                        user.Id.ToString(),
                        "12345@43212345678",
                        "https://mysite.com",
                        "https://mysite.com",
                        TimeSpan.FromMinutes(1200),
                        claims.ToArray());


                    var tokenReturn = new JwtSecurityTokenHandler().WriteToken(token);


                    res.CodStatus = HttpStatusCode.OK;
                    res.Success = true;
                    res.Obj = new AuthenticateResponse(user, tokenReturn, nickname);
                    res.Message.Add("Logueado");

                    _noSQLConnection.Create(new LogDto(user.Email, true, DateTime.Now));
                    return res;
                }


            }
        }

    }
}
