﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tibos.Domain;
using Tibos.IService.Tibos;

namespace Tibos.Admin.Components
{
    public class MenuViewComponent:ViewComponent
    {
        private INavigationService _navigationService;

        public MenuViewComponent(INavigationService navigationIService)
        {
            this._navigationService = navigationIService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var list = _navigationService.GetList();
            return View(list);
        }
    }
}
