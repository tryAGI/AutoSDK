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
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        ViewFull,
        /// <summary>
        /// Contains the recipe of the resource.
        /// </summary>
        ViewRecipe,
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
                PipelinePublicServiceListNamespacePipelinesView.ViewBasic => "VIEW_BASIC",
                PipelinePublicServiceListNamespacePipelinesView.ViewFull => "VIEW_FULL",
                PipelinePublicServiceListNamespacePipelinesView.ViewRecipe => "VIEW_RECIPE",
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
                "VIEW_BASIC" => PipelinePublicServiceListNamespacePipelinesView.ViewBasic,
                "VIEW_FULL" => PipelinePublicServiceListNamespacePipelinesView.ViewFull,
                "VIEW_RECIPE" => PipelinePublicServiceListNamespacePipelinesView.ViewRecipe,
                _ => null,
            };
        }
    }
}