﻿using FoxClub.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Controllers
{
    public class FoxController : Controller
    {
        public FoxContainer FoxContainer { get; set; }

        public FoxController(FoxContainer foxContainer)
        {
            FoxContainer = foxContainer;
        }
    }
}
