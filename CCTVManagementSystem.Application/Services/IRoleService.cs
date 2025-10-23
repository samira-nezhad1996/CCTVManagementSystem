namespace CCTVManagementSystem.Application.Services;

public interface IRoleService
{
    Task<bool> Create(string name);
    Task<bool> Delete();
    Task<bool> Update();

}