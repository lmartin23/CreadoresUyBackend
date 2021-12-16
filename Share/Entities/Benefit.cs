﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Entities
{
    public class Benefit: BaseEntity
    {
        public string Description;

        public int IdPlan { get; set; }
        public Plan Plan { get; set; }

        public Benefit() { }
        public Benefit(string description, int idPlan, Plan plan)
        {
            Description = description;
            IdPlan = idPlan;
            Plan = plan;
        }
    }
}
