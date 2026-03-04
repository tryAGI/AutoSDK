//HintName: G.Models.PipelinePublicServiceListNamespacePipelineReleasesView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinePublicServiceListNamespacePipelineReleasesView
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
    public static class PipelinePublicServiceListNamespacePipelineReleasesViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceListNamespacePipelineReleasesView value)
        {
            return value switch
            {
                PipelinePublicServiceListNamespacePipelineReleasesView.ViewBasic => "VIEW_BASIC",
                PipelinePublicServiceListNamespacePipelineReleasesView.ViewFull => "VIEW_FULL",
                PipelinePublicServiceListNamespacePipelineReleasesView.ViewRecipe => "VIEW_RECIPE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceListNamespacePipelineReleasesView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceListNamespacePipelineReleasesView.ViewBasic,
                "VIEW_FULL" => PipelinePublicServiceListNamespacePipelineReleasesView.ViewFull,
                "VIEW_RECIPE" => PipelinePublicServiceListNamespacePipelineReleasesView.ViewRecipe,
                _ => null,
            };
        }
    }
}