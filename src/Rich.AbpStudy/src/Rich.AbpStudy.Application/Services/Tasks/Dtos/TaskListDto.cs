﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using Rich.AbpStudy.AggregatesModel.TaskAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rich.AbpStudy.Services.Tasks.Dtos
{
    [AutoMapFrom(typeof(Task))]
    public class TaskListDto : EntityDto, IHasCreationTime
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State { get; set; }
    }
}
