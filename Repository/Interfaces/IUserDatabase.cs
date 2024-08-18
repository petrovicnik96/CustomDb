namespace Custom_Database.Repository.Interfaces;

internal interface IUserDatabase
{
    public Task InsertAsync(UserModel user);
    public Task UpdateAsync(UserModel user);
    public Task DeleteAsync(UserModel user);
    public Task<UserModel> GetByIdAsync(UserModel user);
    public Task<IEnumerable<UserModel>> GetByAsync(string name, string age);  
}
