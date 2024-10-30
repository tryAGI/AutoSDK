//HintName: G.Models.PipelinePublicServiceListNamespacePipelinesView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceListNamespacePipelinesView
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
    public static class PipelinePublicServiceListNamespacePipelinesViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceListNamespacePipelinesView value)
        {
            return value switch
            {
                PipelinePublicServiceListNamespacePipelinesView.VIEWBASIC => "VIEW_BASIC",
                PipelinePublicServiceListNamespacePipelinesView.VIEWFULL => "VIEW_FULL",
                PipelinePublicServiceListNamespacePipelinesView.VIEWRECIPE => "VIEW_RECIPE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceListNamespacePipelinesView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceListNamespacePipelinesView.VIEWBASIC,
                "VIEW_FULL" => PipelinePublicServiceListNamespacePipelinesView.VIEWFULL,
                "VIEW_RECIPE" => PipelinePublicServiceListNamespacePipelinesView.VIEWRECIPE,
                _ => null,
            };
        }
    }
}