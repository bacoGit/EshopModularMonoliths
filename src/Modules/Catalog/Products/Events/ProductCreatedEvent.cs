using Catalog.Products.Models;

namespace Catalog.Products.Events;

public record ProductCreatedEvent(Product Prduct) : IDomainEvent;