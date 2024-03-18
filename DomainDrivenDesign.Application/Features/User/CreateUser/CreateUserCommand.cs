using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Application.Features.User.CreateUser
{
    public sealed record CreateUserCommand(
        string name,
        string email,
        string password,
        string country,
            string city,
            string street,
            string postalCode,
            string fullAddress
        ) :IRequest;



    internal sealed class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitfWork unitfWork;
        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async  Task Handle(CreateUserCommand request,CancellationToken cancellationToken)
        {
            await userRepository.CreateAsync(
                request.name,
                request.email,
                request.password,   
                request.country,    
                request.city,   
                request.street, 
                request.postalCode, 
                request.fullAddress,
                cancellationToken
                    
                );

            await unitfWork.SaveChangesAsync( cancellationToken );  
        }


    }


}
