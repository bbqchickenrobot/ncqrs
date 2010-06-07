﻿namespace Ncqrs.Domain.Mapping
{
    /// <summary>
    /// A marker interface informing <see cref="IAggregateRootFactory"/> 
    /// to create an aggregate root mixin with <see cref="ExpressionBasedDomainEventHandlerMappingStrategy"/>.
    /// </summary>
    public interface IAggregateRootMappedWithExpressions
    {
    }
}