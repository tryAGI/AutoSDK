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
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_FULL")]
        ViewFull,
        /// <summary>
        /// Contains the recipe of the resource.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_RECIPE")]
        ViewRecipe,
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
                PipelinePublicServiceListComponentRunsView.ViewBasic => "VIEW_BASIC",
                PipelinePublicServiceListComponentRunsView.ViewFull => "VIEW_FULL",
                PipelinePublicServiceListComponentRunsView.ViewRecipe => "VIEW_RECIPE",
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
                "VIEW_BASIC" => PipelinePublicServiceListComponentRunsView.ViewBasic,
                "VIEW_FULL" => PipelinePublicServiceListComponentRunsView.ViewFull,
                "VIEW_RECIPE" => PipelinePublicServiceListComponentRunsView.ViewRecipe,
                _ => null,
            };
        }
    }
}