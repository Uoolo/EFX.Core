﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tibos.Domain;
using Tibos.IRepository;
using Tibos.IService.Tibos;


//EFX Code Generation Template 1.0
//author:Tibos
//blog:www.cnblogs.com/Tibos
//Entity Code Generation Template
namespace Tibos.Service.Tibos
{
	public class NavigationRoleService:BaseService<NavigationRole>,INavigationRoleService
	{
		private readonly IBaseRepository<NavigationRole> dao;
        public NavigationRoleService(IBaseRepository<NavigationRole> dao):base(dao)
		{
            this.dao = dao;
        }
	}
}