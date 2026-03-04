//HintName: G.Models.PipelinePublicServiceListNamespacePipelinesVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PipelinePublicServiceListNamespacePipelinesVisibility
    {
        /// <summary>
        /// Only the user can see the pipeline.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VISIBILITY_PRIVATE")]
        VisibilityPrivate,
        /// <summary>
        /// Other users can see the pipeline.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VISIBILITY_PUBLIC")]
        VisibilityPublic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinePublicServiceListNamespacePipelinesVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceListNamespacePipelinesVisibility value)
        {
            return value switch
            {
                PipelinePublicServiceListNamespacePipelinesVisibility.VisibilityPrivate => "VISIBILITY_PRIVATE",
                PipelinePublicServiceListNamespacePipelinesVisibility.VisibilityPublic => "VISIBILITY_PUBLIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceListNamespacePipelinesVisibility? ToEnum(string value)
        {
            return value switch
            {
                "VISIBILITY_PRIVATE" => PipelinePublicServiceListNamespacePipelinesVisibility.VisibilityPrivate,
                "VISIBILITY_PUBLIC" => PipelinePublicServiceListNamespacePipelinesVisibility.VisibilityPublic,
                _ => null,
            };
        }
    }
}