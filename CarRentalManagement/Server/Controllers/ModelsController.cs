﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public ModelsController(ApplicationDbContext context)
        public ModelsController(IUnitOfWork unitOfWork) 
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Models
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Model>>> GetModels()
        public async Task<IActionResult> GetModels()
        {
            //if (_context.Models == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.Models.ToListAsync();
            var models = await _unitOfWork.Models.GetAll();
            return Ok(models);
        }

        // GET: api/Models/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Model>> GetModel(int id)
        {
            //if (_context.Models == null)
            //{
            //    return NotFound();
            //}
            var model = await _unitOfWork.Models.Get(q => q.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        // PUT: api/Models/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModel(int id, Model model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Model).State = EntityState.Modified;
            _unitOfWork.Models.Update(model);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!ModelExists(id))
                if(!await ModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Models
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Model>> PostModel(Model model)
        {
          //if (_context.Models == null)
          //{
          //    return Problem("Entity set 'ApplicationDbContext.Models'  is null.");
          //}
          //  _context.Models.Add(Model);
          //  await _context.SaveChangesAsync();
            await _unitOfWork.Models.Insert(model);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetModel", new { id = model.Id }, model);
        }

        // DELETE: api/Models/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModel(int id)
        {
            //if (_context.Models == null)
            //{
            //    return NotFound();
            //}
            //var Model = await _context.Models.FindAsync(id);
            var model = await _unitOfWork.Models.Get(q => q.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            //_context.Models.Remove(Model);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Models.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool ModelExists(int id)
        private async Task<bool> ModelExists(int id)
        {
            var model = await _unitOfWork.Models.Get(q => q.Id == id);
            //return (_context.Models?.Any(e => e.Id == id)).GetValueOrDefault();
            return model != null;
        }
    }
}
