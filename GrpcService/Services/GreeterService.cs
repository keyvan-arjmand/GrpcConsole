using Grpc.Core;
using GrpcService;
using Microsoft.EntityFrameworkCore;
using User;


namespace GrpcService.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
        //public override async Task<List<GetAllUser>> CreateUser(CreateUser user, ServerCallContext context)
        //{
        //    Curd services = new Curd();
        //    DB db = new DB();

        //    services.Create(new User.User
        //    {
        //        Name = user.Name,
        //        Email = user.Email,
        //        Details = new User.Details
        //        {
        //            Id = user.Details.Id,
        //            Address = user.Details.Address,
        //            PhoneNumber = user.Details.PhoneNumber,
        //        }
        //    });
        //    var result = db.users
        //             .Include(x => x.Details)
        //             .Select(x => new GetAllUser
        //             {


        //             })
        //             .ToListAsync();

        //    return Task.FromResult(new List<GetAllUser>().AddRange(result));

        //}
    }
}