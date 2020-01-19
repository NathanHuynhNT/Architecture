using DotNetCore.Repositories;
using Architecture.Domain;
using Architecture.Model;
using System.Threading.Tasks;

namespace Architecture.Database
{
    public interface IUserRepository : IRelationalRepository<UserEntity>
    {
        Task<SignedInModel> SignInAsync(SignInModel signInModel);

        Task UpdateStatusAsync(UserEntity userEntity);
    }
}
