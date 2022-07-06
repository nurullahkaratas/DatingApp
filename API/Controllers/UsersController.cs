using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    // [Route("Users")]
    // [Produces("application/json")]
    // [ApiExplorerSettings(GroupName = "Users")]
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            var users = await _userRepository.GetMembersAsync();
            return Ok(users);

        }
        // [HttpGet("{id}")]
        // public async Task<ActionResult<AppUser>> GetUsers(int id)
        // {
        //     return Ok(await _userRepository.GetUserByIdAsync(id));
        // }
        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUsers(string username)
        {
            var user = await _userRepository.GetMemberAsync(username);
            return Ok(user);
        }
        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            var book = await _userRepository.GetBooks();
            return Ok(book);
        }


    }
}