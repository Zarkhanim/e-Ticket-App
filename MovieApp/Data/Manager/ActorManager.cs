﻿using eTickets.Data.Base;
using eTickets.Data.Context;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorManager : EntityBaseRepository<Actor> ,IActorService
    {
        public ActorManager(AppDBContext context) : base(context) { }
    }
}
