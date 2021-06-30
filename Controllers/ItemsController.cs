using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using System.Collections.Generic;
using Catalog.Entities;
using System;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRepository repository;

        public ItemsController() { repository = new InMemItemsRepository(); }

        [HttpGet]
        public IEnumerable<Item> GetItem()
        {
            return repository.GetItems();
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }
    }
}