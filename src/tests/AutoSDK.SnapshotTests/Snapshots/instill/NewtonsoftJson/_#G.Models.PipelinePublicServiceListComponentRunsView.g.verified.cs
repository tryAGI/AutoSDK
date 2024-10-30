//HintName: G.Models.PipelinePublicServiceListComponentRunsView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinePublicServiceListComponentRunsView
    {
        /// <summary>
        /// Default view, only includes basic information.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_BASIC")]
        VIEWBASIC,
        /// <summary>
        /// Full representation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_FULL")]
        VIEWFULL,
        /// <summary>
        /// Contains the recipe of the resource.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_RECIPE")]
        VIEWRECIPE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinePublicServiceListComponentRunsViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceListComponentRunsView value)
        {
            return value switch
            {
                PipelinePublicServiceListComponentRunsView.VIEWBASIC => "VIEW_BASIC",
                PipelinePublicServiceListComponentRunsView.VIEWFULL => "VIEW_FULL",
                PipelinePublicServiceListComponentRunsView.VIEWRECIPE => "VIEW_RECIPE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceListComponentRunsView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceListComponentRunsView.VIEWBASIC,
                "VIEW_FULL" => PipelinePublicServiceListComponentRunsView.VIEWFULL,
                "VIEW_RECIPE" => PipelinePublicServiceListComponentRunsView.VIEWRECIPE,
                _ => null,
            };
        }
    }
}