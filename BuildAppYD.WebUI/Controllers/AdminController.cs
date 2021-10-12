using AutoMapper;
using BuildAppYD.WebUI.ApiService;
using BuildAppYD.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildAppYD.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IMapper _mapper;

        private readonly BuildingApiService _buildingApiService;
        private readonly RoomApiService _roomApiService;
        private readonly StoreApiService _storeApiService;
        public AdminController( IMapper mapper, BuildingApiService buildingApiService, RoomApiService roomApiService, StoreApiService storeApiService)
        {
            _buildingApiService = buildingApiService;
            _roomApiService = roomApiService;
            _storeApiService = storeApiService;

            _mapper = mapper;
        }
        #region Building

        [HttpGet("getListBuilding")]
        public async Task<IActionResult> getListBuilding()
        {
            var result = await _buildingApiService.getListAsyc();

            return View(_mapper.Map<IEnumerable<BuildingModel>>(result));

        }

        [HttpGet("AddBuilding")]
        public IActionResult AddBuilding()
        {
            return View(new BuildingModel());
        }
        [HttpPost("AddBuilding")]
        public async Task<IActionResult> AddBuilding(BuildingModel buildingModel)
        {
            var result = await _buildingApiService.AddAsync(buildingModel);

            TempData["MethodBilgisi"] = result; // Ekleme Bilgisi Viewa taşınır. 

            return RedirectToAction("getListBuilding");

        }

        [HttpGet("UpdateBuilding")]
        public async Task<IActionResult> UpdateBuilding(int Id)
        {
            var result = await _buildingApiService.getDetailAsycn(Id);

            BuildingModel buildingModel = _mapper.Map<BuildingModel>(result);

            return View(buildingModel);

        }

        [HttpPost("UpdateBuilding")]
        public async Task<IActionResult> UpdateBuilding(BuildingModel buildingModel)
        {

            var result = await _buildingApiService.UpdateAsync(buildingModel);

            TempData["MethodBilgisi"] = result; // Güncelleme Bilgisi Viewa taşınır. 

            return RedirectToAction("getListBuilding");
        }

        [HttpPost("DeleteBuilding")]
        public async Task<IActionResult> DeleteBuilding(int buildingId)
        {

            var result = await _buildingApiService.Delete(buildingId); //Sistem SoftDelete Uygundur. isDeleted kolonu Base olarak eklendi

            TempData["MethodBilgisi"] = result; // Silme Bilgisi Viewa taşınır. 

            return RedirectToAction("getListBuilding");
        }
        #endregion

        #region Room
        [HttpGet("getListRoom")]
        public async Task<IActionResult> getListRoom()
        {
            var result = await _roomApiService.GetListWtihBuildingAsync();
            return View(_mapper.Map<IEnumerable<RoomModel>>(result));
        }

        [HttpGet("AddRoom")]
        public async Task<IActionResult> AddRoom()
        {
            ViewBag.Buildings = await _buildingApiService.getListAsyc();
            return View(new RoomModel());
        }
        [HttpPost("AddRoom")]
        public async Task<IActionResult> AddRoom(RoomModel roomModel)
        {
            var result = await _roomApiService.AddAsync(roomModel);

            TempData["MethodBilgisi"] = result;

            return RedirectToAction("getListRoom");
        }
        [HttpGet("UpdateRoom")]
        public async Task<IActionResult> UpdateRoom(int Id)
        {
            var result = await _roomApiService.getByIdAsycn(Id);

            ViewBag.Buildings = await _buildingApiService.getListAsyc();

            RoomModel roomModel = _mapper.Map<RoomModel>(result);

            return View(roomModel);
        }
        [HttpPost("UpdateRoom")]
        public async Task<IActionResult> UpdateRoom(RoomModel roomModel)
        {
            var result = await _roomApiService.UpdateAsync(roomModel);

            TempData["MethodBilgisi"] = result; 

            return RedirectToAction("getListRoom");
        }

        [HttpPost("DeleteRoom")]
        public async Task<IActionResult> DeleteRoom(int roomId)
        {
            var result = await _roomApiService.Delete(roomId);

            TempData["MethodBilgisi"] = result; 

            return RedirectToAction("getListRoom");
        }
        #endregion

        #region Store
        [HttpGet("getListStore")]
        public async Task<IActionResult> getListStore()
        {
            var result = await _storeApiService.GetListWtihBuildingAsync();
            return View(_mapper.Map<IEnumerable<StoreModel>>(result));
        }


        [HttpGet("AddStore")]
        public async Task<IActionResult> AddStore()
        {
            ViewBag.Buildings = await _buildingApiService.getListAsyc();
            return View(new StoreModel());
        }

        [HttpPost("AddStore")]
        public async Task<IActionResult> AddStore(StoreModel storeModel)
        {
            var result = await _storeApiService.AddAsync(storeModel);

            TempData["MethodBilgisi"] = result;

            return RedirectToAction("getListStore");
        }

        [HttpGet("UpdateStore")]
        public async Task<IActionResult> UpdateStore(int Id)
        {
            var result = await _storeApiService.getByIdAsycn(Id);

            ViewBag.Buildings = await _buildingApiService.getListAsyc();

            StoreModel storeModel = _mapper.Map<StoreModel>(result);

            return View(storeModel);
        }
        [HttpPost("UpdateStore")]
        public async Task<IActionResult> UpdateStore(StoreModel storeModel)
        {
            var result =await _storeApiService.UpdateAsync(storeModel);

            TempData["MethodBilgisi"] = result;

            return RedirectToAction("getListStore");
        }

        [HttpPost("DeleteStore")]
        public async Task<IActionResult> DeleteStore(int storeId)
        {
            var result = await _storeApiService.Delete(storeId);

            TempData["MethodBilgisi"] = result;

            return RedirectToAction("getListStore");
        }
        #endregion

    }
}
