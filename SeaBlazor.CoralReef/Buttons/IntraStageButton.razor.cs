using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace SeaBlazor.CoralReef
{
    public partial class IntraStageButton : ComponentBase
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter]
        public IntraStageButtonType Type { get; set; }

        [Parameter]
        public string? Class { get; set; }

        [Parameter]
        public string? Style { get; set; }

        [Parameter]
        public EventCallback OnClick { get; set; }
    }

    public enum IntraStageButtonType
    {
        Submit,
        Button,
        Reset
    }

    internal static class IntraStageButtonTypeHelper
    {
        public static string? GetType(IntraStageButtonType type)
        {
            return type switch
            {
                IntraStageButtonType.Submit => "submit",
                IntraStageButtonType.Button => "button",
                IntraStageButtonType.Reset => "reset",
                _ => null
            };
        }
    }
}
