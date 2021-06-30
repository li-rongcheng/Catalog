using System;
using Catalog.Entities;

namespace Catalog.Dtos
{
    public record ItemDto : Item
    {
        public ItemDto(Item original) : base(original)
        { }
    }
}