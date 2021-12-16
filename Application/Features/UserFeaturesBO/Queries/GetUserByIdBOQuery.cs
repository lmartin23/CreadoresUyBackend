﻿using Application.Interface;
using AutoMapper;
using MediatR;
using Share.Dtos;
using Share.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.UserFeaturesBO.Queries
{
    public class GetUserByIdBOQuery : IRequest<Response<UserBODto>>
    {
        public int Id {  get; set; }

        public class GetUserByIdBOQueryHandler : IRequestHandler<GetUserByIdBOQuery, Response<UserBODto>>
        {
            private readonly ICreadoresUyDbContext _context;
            private readonly IMapper _mapper;

            public GetUserByIdBOQueryHandler(ICreadoresUyDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<Response<UserBODto>> Handle(GetUserByIdBOQuery query, CancellationToken cancellationToken)
            {
                var user = _context.Users.Where(u => u.Id == query.Id).FirstOrDefault();
                Response<UserBODto> res = new();
                res.Message = new List<string>();
                //if (user == null || user.Deleted == true)
                if (user == null)
                {
                    res.Obj = default;
                    res.CodStatus = HttpStatusCode.BadRequest;
                    res.Success = false;
                    var msj = "No se ha encontrado un usuario asociado al id ingresado";
                    res.Message.Add(msj);
                    return res;
                }
                var dto = _mapper.Map<UserBODto>(user);
                dto.NoNulls();
                res.Obj = dto;
                res.CodStatus = HttpStatusCode.OK;
                res.Success = true;
                var msj1 = "Ok";
                res.Message.Add(msj1);
                return res;

            }

        }
    }
}
