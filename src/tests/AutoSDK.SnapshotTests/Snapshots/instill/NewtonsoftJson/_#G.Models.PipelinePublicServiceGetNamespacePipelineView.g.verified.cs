//HintName: G.Models.PipelinePublicServiceGetNamespacePipelineView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinePublicServiceGetNamespacePipelineView
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
    public static class PipelinePublicServiceGetNamespacePipelineViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceGetNamespacePipelineView value)
        {
            return value switch
            {
                PipelinePublicServiceGetNamespacePipelineView.ViewBasic => "VIEW_BASIC",
                PipelinePublicServiceGetNamespacePipelineView.ViewFull => "VIEW_FULL",
                PipelinePublicServiceGetNamespacePipelineView.ViewRecipe => "VIEW_RECIPE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceGetNamespacePipelineView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => PipelinePublicServiceGetNamespacePipelineView.ViewBasic,
                "VIEW_FULL" => PipelinePublicServiceGetNamespacePipelineView.ViewFull,
                "VIEW_RECIPE" => PipelinePublicServiceGetNamespacePipelineView.ViewRecipe,
                _ => null,
            };
        }
    }
}