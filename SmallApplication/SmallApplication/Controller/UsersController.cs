using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmallApplication.Constants;
using SmallApplication.Models;
using SmallApplication.Repositories;

namespace SmallApplication.Controller
{
    [ApiController]
    [Route(ApiRoutes.Users)]
    public class UsersController : ControllerBase
    {
        private readonly UserRepository _repository;

        public UsersController(UserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _repository.GetUsers();
        }
    }
}

