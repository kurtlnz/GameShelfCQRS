using System;
using System.Threading.Tasks;
using GameShelf.Domain;
using GameShelf.Domain.Models;
using Microsoft.Extensions.Logging;

namespace GameShelf.Repository.Commands.Users
{
    public interface IDeleteUserCommand
    {
        Task<Result> Execute(Guid id);
    }

    public class DeleteUserCommand : IDeleteUserCommand
    {
        private readonly GameShelfContext _context;
        private readonly ILogger<DeleteUserCommand> _logger;

        public DeleteUserCommand(GameShelfContext context, ILogger<DeleteUserCommand> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<Result> Execute(Guid id)
        {
            Result result = new Result();
            var user = new User{ Id = id };
            try
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                result.AddError(ex.Message);
            }

            return result;
        }
    }
}