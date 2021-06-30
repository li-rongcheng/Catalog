using System;
using Catalog.Dtos;

namespace Catalog.Entities
{
    public record Item
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreateDate { get; init; }

        public ItemDto AsDto()
        {
            return new ItemDto(this) { Price = this.Price * 10 };
        }
    }
}