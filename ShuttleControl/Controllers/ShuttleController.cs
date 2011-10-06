using System;
using System.Web.Mvc;
using ShuttleControl.Models;
using ShuttleControl.Repositories;
using ShuttleControl.Repositories.Impl;

namespace ShuttleControl.Controllers
{
	public class ShuttleController : Controller
	{
		private readonly IShuttleRepository _shuttleRepository;

		public ShuttleController()
		{
			this._shuttleRepository = new ShuttleRepository();
		}

		public ShuttleController(IShuttleRepository shuttleRepository)
		{
			this._shuttleRepository = shuttleRepository;
		}

		[HttpGet]
		public ViewResult Index()
		{
			ViewBag.Message = TempData["Message"];
			var models = _shuttleRepository.GetAll();
			return View(models);
		}

		[HttpGet]
		public ViewResult Create()
		{
			return View("Edit", new Shuttle());
		}

		[HttpGet]
		public ViewResult Edit(Guid id)
		{
			var model = _shuttleRepository.GetById(id);
			return View(model);
		}

		[HttpGet]
		public RedirectToRouteResult Delete(Guid id)
		{
			_shuttleRepository.Delete(id);
			return RedirectToAction("Index");
		}

		[HttpPost]
		public RedirectToRouteResult Save(Shuttle model)
		{
			_shuttleRepository.Save(model);
			TempData["Message"] = "Successfully saved " + model.Name;
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ViewResult Control(Guid id)
		{
			ViewBag.Message = TempData["Message"];
			var model = _shuttleRepository.GetById(id);
			return View(model);
		}

		[HttpPost]
		public RedirectToRouteResult Load(Guid id, string payload)
		{
			var wocket = _shuttleRepository.GetById(id);
			if(wocket.IsReadyToLoad())
			{
				TempData["Message"] = "Successfully loaded " + payload + " into " + wocket.Name;
				wocket.LoadPayload(payload);
				_shuttleRepository.Save(wocket);
				return RedirectToAction("Control", new { Id = id });
			}

			TempData["Message"] = "Failed to load " + wocket.Name;
			return RedirectToAction("Control", new { Id = id });
		}

		[HttpGet]
		public RedirectToRouteResult Launch(Guid id)
		{
			var wocket = _shuttleRepository.GetById(id);
			if(wocket.IsReadyToLaunch())
			{
				TempData["Message"] = "Successfully launched " + wocket.Name;
				wocket.Launch();
				_shuttleRepository.Save(wocket);
				return RedirectToAction("Control", new { Id = id });
			}

			TempData["Message"] = "Failed to launch " + wocket.Name;
			return RedirectToAction("Control", new { Id = id });
		}

		[HttpGet]
		public RedirectToRouteResult Land(Guid id)
		{
			var wocket = _shuttleRepository.GetById(id);
			if(wocket.IsReadyToLand())
			{
				TempData["Message"] = "Successfully landed " + wocket.Name;
				wocket.Land();
				_shuttleRepository.Save(wocket);
				return RedirectToAction("Control", new { Id = id });
			}

			TempData["Message"] = "Failed to land " + wocket.Name;
			return RedirectToAction("Control", new { Id = id });
		}

		[HttpGet]
		public RedirectToRouteResult Release(Guid id)
		{
			var wocket = _shuttleRepository.GetById(id);
			if(wocket.IsReadyToRelease())
			{
				TempData["Message"] = wocket.Name + " successfully released payload of " + wocket.Payload;
				wocket.ReleasePayload();
				_shuttleRepository.Save(wocket);
				return RedirectToAction("Control", new { Id = id });
			}

			TempData["Message"] = wocket.Name + " failed to release payload";
			return RedirectToAction("Control", new { Id = id });
		}
	}
}
