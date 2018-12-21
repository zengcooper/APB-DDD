﻿using Abp.Localization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rich.AbpStudy.AggregatesModel.TaskAggregate;
using Rich.AbpStudy.Services.Tasks.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rich.AbpStudy.Web.ViewModels
{
    public class IndexViewModel
    {
        public IReadOnlyList<TaskListDto> Tasks { get; }

        public IndexViewModel(IReadOnlyList<TaskListDto> tasks)
        {
            Tasks = tasks;
        }

        public string GetTaskLabel(TaskListDto task)
        {
            switch (task.State)
            {
                case TaskState.Open:
                    return "label-success";
                default:
                    return "label-default";
            }
        }

        public TaskState? SelectedTaskState { get; set; }

        public List<SelectListItem> GetTasksStateSelectListItems(ILocalizationManager localizationManager)
        {
            var list = new List<SelectListItem>
        {
            new SelectListItem
            {
                Text = localizationManager.GetString(AbpStudyConsts.LocalizationSourceName, "AllTasks"),
                Value = "",
                Selected = SelectedTaskState == null
            }
        };

            list.AddRange(Enum.GetValues(typeof(TaskState))
                    .Cast<TaskState>()
                    .Select(state =>
                        new SelectListItem
                        {
                            Text = localizationManager.GetString(AbpStudyConsts.LocalizationSourceName, $"TaskState_{state}"),
                            Value = state.ToString(),
                            Selected = state == SelectedTaskState
                        })
            );

            return list;
        }
    }
}
