using BlazorCrud.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.Data.Repositorio
{
    public class UsuarioRepositorio //: IUsuarioRepositorio
    {
        /*private string ConnectionString;
        public UsuarioRepositorio(string connectionString)
        {
            ConnectionString = connectionString;
        }
        protected SqlConnection DbConnection()
        {
            return new SqlConnection(ConnectionString);
           
        }
        public Task<bool> DeleteUsuarios(Usuarios usuarios)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuarios>> GetAllUsuarios()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuarios>> GetUsuarios(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertUsuarios(Usuarios usuarios)
        {
            var db = DbConnection();
            var sql = @"
                        Insert into AspNetUsers	([UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnabled], [AccessFailedCount])
                        values (@[UserName], @[NormalizedUserName], @[Email], @[NormalizedEmail], @[EmailConfirmed], @[PasswordHash], @[SecurityStamp], @[ConcurrencyStamp], @[PhoneNumberConfirmed], @[TwoFactorEnabled], @[LockoutEnabled], @[AccessFailedCount])";
            var result = await db.ExecuteAsync(sql.ToString(), new { usuarios.UserName,usuarios.NormalizedUserName, usuarios.Email, usuarios.NormalizedEmail, usuarios.EmailConfirmed, usuarios.PasswordHash, usuarios.SecurityStamp, usuarios.ConcurrencyStamp, usuarios.PhoneNumberConfirmed, usuarios.TwoFactorEnabled, usuarios.LockoutEnabled, usuarios.AccessFailedCount });
            return result > 0;
        }

        public Task<bool> UpdateUsuarios(Usuarios usuarios)
        {
            throw new NotImplementedException();
        }*/
    }
}
