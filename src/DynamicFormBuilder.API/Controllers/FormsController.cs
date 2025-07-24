using Microsoft.AspNetCore.Mvc;

using DynamicFormBuilder.Application.DTOs;
using DynamicFormBuilder.Application.Common;
using DynamicFormBuilder.Application.Interfaces;

namespace DynamicFormBuilder.API.Controllers;

[ApiController]
[Route("api/forms")]
public class FormsController(IFormService formService) : ControllerBase
{
    private readonly IFormService _formService = formService;


    /// <summary>
    /// Crea un nuevo formulario dinámico.
    /// </summary>
    /// <param name="dto">Datos del formulario a crear.</param>
    /// <returns>Formulario creado con su ID asignado.</returns>
    [HttpPost("create")]
    public async Task<ActionResult<FormResponseDto>> CreateAsync(FormCreateDto dto)
    {
        var result = await _formService.AddAsync(dto);
        //return CreatedAtAction("GetFormById", new { id = result.Id }, result);
        return Ok(result);
    }

    /// <summary>
    /// Actualiza un formulario existente.
    /// </summary>
    /// <param name="id">ID del formulario a actualizar.</param>
    /// <param name="dto">Datos actualizados del formulario.</param>
    /// <returns>Formulario actualizado o 404 si no existe.</returns>
    [HttpPut("update/{id}")]
    public async Task<ActionResult<FormResponseDto>> UpdateAsync(Guid id, FormUpdateDto dto)
    {
        var result = await _formService.UpdateAsync(id, dto);
        if (result == null)
            return NotFound();

        return Ok(result);
    }

    /// <summary>
    /// Obtiene la lista completa de formularios registrados.
    /// </summary>
    /// <returns>Lista de formularios.</returns>
    [HttpGet("list")]
    public async Task<ActionResult<IEnumerable<FormResponseDto>>> GetAllAsync()
    {
        var result = await _formService.GetAllAsync();
        return Ok(result);
    }

    /// <summary>
    /// Obtiene los detalles de un formulario específico por su ID.
    /// </summary>
    /// <param name="id">ID del formulario.</param>
    /// <returns>Formulario encontrado o 404 si no existe.</returns>
    [HttpGet("details/{id}")]
    public async Task<ActionResult<FormResponseDto>> GetByIdAsync(Guid id)
    {
        var result = await _formService.GetByIdAsync(id);
        if (result == null)
            return NotFound();

        return Ok(result);
    }

    /// <summary>
    /// Obtiene una lista paginada de formularios.
    /// </summary>
    /// <param name="page">Número de página (por defecto 1).</param>
    /// <param name="pageSize">Cantidad de elementos por página (por defecto 10).</param>
    /// <returns>Lista paginada de formularios.</returns>
    [HttpGet("paged")]
    public async Task<ActionResult<PagedResult<FormResponseDto>>> GetPagedAsync([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
    {
        var result = await _formService.GetPagedAsync(page, pageSize);
        return Ok(result);
    }
}
