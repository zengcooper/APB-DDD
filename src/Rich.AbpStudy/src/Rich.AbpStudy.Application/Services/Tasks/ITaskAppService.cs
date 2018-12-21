using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Rich.AbpStudy.Services.Tasks.Dtos;
using System.Threading.Tasks;

namespace Rich.AbpStudy.Services.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        Task<ListResultDto<TaskListDto>> GetAll(GetAllTasksInput input);
    }
}
