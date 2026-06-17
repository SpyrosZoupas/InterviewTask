using Fines.Core.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fines.Api;

[Route("api/[controller]")]
[ApiController]
public class FinesController : ControllerBase
{
    private readonly IFinesService _finesService;

    public FinesController(IFinesService finesService)
    {
        _finesService = finesService;
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<FinesResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<FinesResponse>>> GetFines(
        [FromQuery] FineFiltersRequest? filters = null)
    {
        try
        {
            if (filters?.FromDate.HasValue == true && filters.ToDate.HasValue == true && filters.FromDate > filters.ToDate)
            {
                return BadRequest(new ErrorResponse
                {
                    Message = "FromDate must be earlier than ToDate.",
                    TraceId = HttpContext.TraceIdentifier
                });
            }


            var fines = await _finesService.GetFinesAsync(filters);

            return Ok(fines);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponse
            {
                Message = "An unexpected error occurred while retrieving fines.",
                TraceId = HttpContext.TraceIdentifier
            });
        }
    }
}

public class ErrorResponse
{
    public string Message { get; set; } = string.Empty;
    public string? TraceId { get; set; }
}
