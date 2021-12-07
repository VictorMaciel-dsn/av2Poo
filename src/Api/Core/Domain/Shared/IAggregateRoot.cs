﻿using System.Collections.Generic;
using MediatR;

namespace Av2Poo.Api.Core.Domain.Shared
{
    public interface IAggregateRoot
    {
        ICollection<INotification> GetDomainEvents();
        void ClearDomainEvents();
    }
}