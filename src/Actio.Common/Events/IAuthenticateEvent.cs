using System;

namespace Actio.Common.Events
{
    public interface IAuthenticateEvent : IEvent
    {
        Guid UserId { get; }
    }
}