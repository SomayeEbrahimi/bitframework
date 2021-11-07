﻿using System.Collections.Generic;
using Bit.Client.Web.BlazorUI.Playground.Web.Models;
using Bit.Client.Web.BlazorUI.Playground.Web.Pages.Components.ComponentDemoBase;
using Bit.Client.Web.BlazorUI.Playground.Web.Services;
using Microsoft.AspNetCore.Components;

namespace Bit.Client.Web.BlazorUI.Playground.Web.Components
{
    public partial class ComponentPage
    {
        private List<SideRailItems> sideRailItems { get; set; } = new()
        {
            new SideRailItems()
            {
                Title = "Overview",
                Id = "overview-section"
            },
            new SideRailItems()
            {
                Title = "Usage",
                Id = "usage-section"
            },
            new SideRailItems()
            {
                Title = "Implementation",
                Id = "implementation-section"
            }
        };

        [Inject] public NavManuService NavManuService { get; set; }

        [Parameter] public string ComponentName { get; set; }
        [Parameter] public string OverviewDesc { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public List<EnumParameter> EnumParameters { get; set; } = new();
        [Parameter] public List<ComponentParameter> ComponentParameters { get; set; } = new();
        [Parameter] public List<ComponentSubParameter> ComponentSubParameters { get; set; } = new();

        private void ToggleMenu()
        {
            NavManuService.ToggleMenu();
        }
    }
}
