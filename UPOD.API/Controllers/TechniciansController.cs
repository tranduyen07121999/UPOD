﻿using Microsoft.AspNetCore.Mvc;
using UPOD.REPOSITORIES.RequestModels;
using UPOD.REPOSITORIES.ResponseModels;
using ITechnicianService = UPOD.SERVICES.Services.ITechnicianService;

namespace UPOD.API.Controllers
{
    [ApiController]
    [Route("api/technicians")]
    public partial class TechniciansController : ControllerBase
    {

        private readonly ITechnicianService _technician_sv;
        public TechniciansController(ITechnicianService technician_sv)
        {
            _technician_sv = technician_sv;
        }

        [HttpGet]
        [Route("get_list_technicians")]
        public async Task<ActionResult<ResponseModel<TechnicianResponse>>> GetListTechnicians([FromQuery] PaginationRequest model)
        {
            try
            {
                return await _technician_sv.GetListTechnicians(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("get_technician_details")]
        public async Task<ActionResult<ObjectModelResponse>> GetDetailsTechnician(Guid id)
        {
            try
            {
                return await _technician_sv.GetDetailsTechnician(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("get_list_requests_by_id_technician")]
        public async Task<ActionResult<ResponseModel<RequestResponse>>> GetListRequestsOfTechnician([FromQuery] PaginationRequest model, Guid id)
        {
            try
            {
                return await _technician_sv.GetListRequestsOfTechnician(model, id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("get_list_ticket_by_request_id")]
        public async Task<ActionResult<ResponseModel<DevicesOfRequestResponse>>> GetDevicesByRequest([FromQuery] PaginationRequest model, [FromQuery] Guid id)
        {
            try
            {
                return await _technician_sv.GetDevicesByRequest(model, id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("create_technician")]
        public async Task<ActionResult<ObjectModelResponse>> CreateTechnician(TechnicianRequest model)
        {
            try
            {
                return await _technician_sv.CreateTechnician(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("create_ticket_by_id_request")]
        public async Task<ActionResult<ResponseModel<DevicesOfRequestResponse>>> CreateTicket(Guid id, ListTicketRequest model)
        {
            try
            {
                return await _technician_sv.CreateTicket(id, model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("resolving_request_by_id")]
        public async Task<ActionResult<ObjectModelResponse>> ResolvingRequest(Guid id)
        {
            try
            {
                return await _technician_sv.ResolvingRequest(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("update_technician_by_id")]
        public async Task<ActionResult<ObjectModelResponse>> UpdateTechnician(Guid id, TechnicianRequest model)
        {
            try
            {
                return await _technician_sv.UpdateTechnician(id, model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("disable_technician_by_id")]
        public async Task<ActionResult<ObjectModelResponse>> DisableTechnician(Guid id)
        {
            try
            {
                return await _technician_sv.DisableTechnician(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
