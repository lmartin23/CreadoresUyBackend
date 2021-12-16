﻿using Share.Dtos;
using Share.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Entities
{
    public class Content : BaseEntity
    {
        public string Title {  get; set; }

        [StringLength(20000)]
        public string Description {  get; set; }

        public DateTime AddedDate {  get; set; }
        public bool IsPublic { get; set; }
        public string Dato {  get; set; }
        public bool Draft { get; set; }
        public DateTime PublishDate {  get; set; }

        public TipoContent Type { get; set; }

        public ICollection<ContentTag> ContentTags { get; set; }

        public ICollection<ContentPlan> ContentPlans {  get; set;}








    }
}
