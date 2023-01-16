using Havillah.ApplicationServices.Interfaces;
using Havillah.ApplicationServices.User.Dto;
using Havillah.Core.Domain;
using Havillah.Shared;
using MediatR;

namespace Havillah.ApplicationServices.User.UseCases.Queries;
<<<<<<< HEAD
<<<<<<< HEAD

<<<<<<< HEAD
=======

>>>>>>> 76516a4 (few changes done here for dev)
public class GetUserByIdUseCaseQuery: IRequest<Result<GetUserDto>>
{
    public Guid Id { get; set; }
    
    public class GetUserByIdUseCaseQueryHandler: IRequestHandler<GetUserByIdUseCaseQuery, Result<GetUserDto>>
    {
        private readonly IRepository<ApplicationUser> _repository;
        public GetUserByIdUseCaseQueryHandler(IRepository<ApplicationUser> repository)
=======
public class GetUserByEmailUseCaseQuery: IRequest<Result<GetUserDto>>
=======
public class GetUserByIdUseCaseQuery: IRequest<Result<GetUserDto>>
>>>>>>> e34493e (modified espense with constructor)
{
    public Guid Id { get; set; }
    
    public class GetUserByIdUseCaseQueryHandler: IRequestHandler<GetUserByIdUseCaseQuery, Result<GetUserDto>>
    {
        private readonly IRepository<ApplicationUser> _repository;
<<<<<<< HEAD
        public GetUserByEmailUseCaseQueryHandler(IRepository<ApplicationUser> repository)
>>>>>>> 56eb5a1 (trying)
        {
            _repository = repository;
        }
        
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 76516a4 (few changes done here for dev)
        public async Task<Result<GetUserDto>> Handle(GetUserByIdUseCaseQuery request, CancellationToken cancellationToken)
        {
            var user = await _repository.Find(predicate: x => x.Id == request.Id);
=======
        public async Task<Result<GetUserDto>> Handle(GetUserByEmailUseCaseQuery request, CancellationToken cancellationToken)
        {
            var user = await _repository.Find(predicate: x => x.Email == request.Email);
>>>>>>> 56eb5a1 (trying)
=======
        public GetUserByIdUseCaseQueryHandler(IRepository<ApplicationUser> repository)
        {
            _repository = repository;
        }
        public async Task<Result<GetUserDto>> Handle(GetUserByIdUseCaseQuery request, CancellationToken cancellationToken)
        {
            var user = await _repository.Find(predicate: x => x.Id == request.Id);
>>>>>>> e34493e (modified espense with constructor)
            if(string.IsNullOrEmpty(user.Email)) return Result.Fail<GetUserDto>("User does not exist");
            return Result.Ok<GetUserDto>(new GetUserDto()
            {
                UserName = user.UserName,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                MiddleName = user.MiddleName
            });
            
        }
    }   
}