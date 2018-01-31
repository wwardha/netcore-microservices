using System;
using System.Threading.Tasks;
using Actio.Common.Commands;
using Actio.Common.Events;
using RawRabbit;

namespace Actio.Services.Identity.Handlers
{
    public class CreateUserHandler : ICommandHandler<CreateUser>
    {
        private readonly IBusClient _busClient;
        
        public CreateUserHandler(IBusClient busClient)
        {
            _busClient = busClient;
        }
        
        public async Task HandleAsync(CreateUser command)
        {
            Console.WriteLine($"Creating user: {command.Name}");
            await _busClient.PublishAsync(new UserCreated(command.Email, command.Name));
        }
    }
}