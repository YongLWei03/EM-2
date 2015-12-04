﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EM.Web.Core;
using EM.Common;
using  System.ComponentModel;
using EM.Data.Repositories;
using EM.Data.Infrastructure;
using EM.Web.Core.Base;
using AutoMapper;
using EM.Model.VMs;
using EM.Model.DTOs;
using System.Threading.Tasks;
using EM.Model.Entities;

namespace EM.Web.Controllers
{
    [Description("公司管理")]
    [ControlType(SystemType.ZJ)]
    public class CompanyController : BaseController
    {

        private readonly ICompanyRepo companyRepo = new CompanyRepo(new DatabaseFactory());
        [Description("公司列表")]
        [ActionType(RightType.View)]
        public async Task< ActionResult> Index(string Name="")
        {
            var Dtos = companyRepo.GetListDto(Name);
            if (Request.IsAjaxRequest())
              return PartialView("_List", Dtos);
            return View(Dtos);
        }
        [Description("新增公司")]
        [ActionType(RightType.View)]
        public async Task<ActionResult> Add()
        {
            var model = new EM_Company();
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Add(EM_Company model)
        {
            model.KPIValue = model.KPIValue.Value * 10000;
            model.ModifyDate = DateTime.Now;
            model.CreateDate = DateTime.Now;
            model.Modifier = ViewHelp.GetUserName();
            model.Creater = ViewHelp.GetUserName();
            companyRepo.Add(model);
            var result=companyRepo.SaveChanges();
            if (result > 0)
                return Json(new { code = 1 });
            else
                return Json(new { code = 0, message = "保存失败，请重试" });
        }

        [Description("编辑公司")]
        [ActionType(RightType.Form)]
        public async Task<ActionResult> Edit(int Id)
        {
            var model = companyRepo.GetById(Id);
            model.KPIPercent = Math.Round(model.KPIPercent.Value, 2);
            model.KPIValue = Math.Round(model.KPIValue.Value/10000, 0);
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(EM_Company model)
        {
            var entity = companyRepo.GetById(model.Id);
            Log(entity);
            entity = Mapper.Map<EM_Company, EM_Company>(model, entity);
            entity.KPIValue = entity.KPIValue.Value * 10000;
            entity.ModifyDate = DateTime.Now;
            entity.Modifier = ViewHelp.GetUserName();
            var result = companyRepo.SaveChanges();
               return Json(new { code = 1 });
        }

        [Description("删除公司")]
        [ActionType(RightType.Form)]
        public async Task<ActionResult> Delete(int Id)
        {
            var model = companyRepo.GetById(Id);
            Log(model);
            companyRepo.Delete(model);
            companyRepo.SaveChanges();
            return View(model);
        }

    }
}
