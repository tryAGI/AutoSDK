//HintName: G.Models.PipelinePublicServiceGetNamespacePipelineReleaseView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinePublicServiceGetNamespacePipelineReleaseView
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
    public static class PipelinePublicServiceGetNamespacePipelineReleaseViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceGetNamespacePipelineReleaseView value)
        {
            return value switch
            {
                PipelinePublicServiceGetNamespacePipelineReleaseView.VIEWBASIC => "VIEW_BASIC",
                PipelinePublicServiceGetNamespacePipelineReleaseView.VIEWFULL => "VIEW_FULL",
                PipelinePublicServiceGetNamespacePipelineReleaseView.VIEWRECIPE => "VIEW_RECIPE",
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
                "VIEW_BASIC" => PipelinePublicServiceGetNamespacePipelineReleaseView.VIEWBASIC,
                "VIEW_FULL" => PipelinePublicServiceGetNamespacePipelineReleaseView.VIEWFULL,
                "VIEW_RECIPE" => PipelinePublicServiceGetNamespacePipelineReleaseView.VIEWRECIPE,
                _ => null,
            };
        }
    }
}