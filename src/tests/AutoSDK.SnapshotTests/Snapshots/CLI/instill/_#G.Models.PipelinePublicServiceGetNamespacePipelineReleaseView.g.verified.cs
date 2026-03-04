//HintName: G.Models.PipelinePublicServiceGetNamespacePipelineReleaseView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceGetNamespacePipelineReleaseView
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
    public static class PipelinePublicServiceGetNamespacePipelineReleaseViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceGetNamespacePipelineReleaseView value)
        {
            return value switch
            {
                PipelinePublicServiceGetNamespacePipelineReleaseView.ViewBasic => "VIEW_BASIC",
                PipelinePublicServiceGetNamespacePipelineReleaseView.ViewFull => "VIEW_FULL",
                PipelinePublicServiceGetNamespacePipelineReleaseView.ViewRecipe => "VIEW_RECIPE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceGetNamespacePipelineReleaseView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceGetNamespacePipelineReleaseView.ViewBasic,
                "VIEW_FULL" => PipelinePublicServiceGetNamespacePipelineReleaseView.ViewFull,
                "VIEW_RECIPE" => PipelinePublicServiceGetNamespacePipelineReleaseView.ViewRecipe,
                _ => null,
            };
        }
    }
}