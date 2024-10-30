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
    public static class PipelinePublicServiceListNamespacePipelineReleasesViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceListNamespacePipelineReleasesView value)
        {
            return value switch
            {
                PipelinePublicServiceListNamespacePipelineReleasesView.VIEWBASIC => "VIEW_BASIC",
                PipelinePublicServiceListNamespacePipelineReleasesView.VIEWFULL => "VIEW_FULL",
                PipelinePublicServiceListNamespacePipelineReleasesView.VIEWRECIPE => "VIEW_RECIPE",
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
                "VIEW_BASIC" => PipelinePublicServiceListNamespacePipelineReleasesView.VIEWBASIC,
                "VIEW_FULL" => PipelinePublicServiceListNamespacePipelineReleasesView.VIEWFULL,
                "VIEW_RECIPE" => PipelinePublicServiceListNamespacePipelineReleasesView.VIEWRECIPE,
                _ => null,
            };
        }
    }
}