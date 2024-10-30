//HintName: G.Models.PipelinePublicServiceListPipelinesView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceListPipelinesView
    {
        /// <summary>
        /// Default view, only includes basic information.
        /// </summary>
        VIEWBASIC,
        /// <summary>
        /// Full representation.
        /// </summary>
        VIEWFULL,
        /// <summary>
        /// Contains the recipe of the resource.
        /// </summary>
        VIEWRECIPE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinePublicServiceListPipelinesViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceListPipelinesView value)
        {
            return value switch
            {
                PipelinePublicServiceListPipelinesView.VIEWBASIC => "VIEW_BASIC",
                PipelinePublicServiceListPipelinesView.VIEWFULL => "VIEW_FULL",
                PipelinePublicServiceListPipelinesView.VIEWRECIPE => "VIEW_RECIPE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceListPipelinesView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceListPipelinesView.VIEWBASIC,
                "VIEW_FULL" => PipelinePublicServiceListPipelinesView.VIEWFULL,
                "VIEW_RECIPE" => PipelinePublicServiceListPipelinesView.VIEWRECIPE,
                _ => null,
            };
        }
    }
}