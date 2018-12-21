using Rich.AbpStudy.AggregatesModel.TaskAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rich.AbpStudy.Services.Tasks.Dtos
{
    public class GetAllTasksInput
    {
        public TaskState? State { get; set; }
    }
}
