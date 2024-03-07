using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IA.Controllers.Common
{
    public abstract class Base<TEntity, TDto> : ControllerBase where TEntity : class where TDto : class
    {

        private readonly DbContext _context;
        private readonly IMapper _mapper;

        public Base(DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public abstract ActionResult<TDto> Get(int id);
    }
}