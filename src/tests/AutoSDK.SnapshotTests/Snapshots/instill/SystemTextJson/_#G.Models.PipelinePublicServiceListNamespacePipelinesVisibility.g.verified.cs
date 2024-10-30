//HintName: G.Models.PipelinePublicServiceListNamespacePipelinesVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceListNamespacePipelinesVisibility
    {
        /// <summary>
        /// Only the user can see the pipeline.
        /// </summary>
        VISIBILITYPRIVATE,
        /// <summary>
        /// Other users can see the pipeline.
        /// </summary>
        VISIBILITYPUBLIC,
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
                PipelinePublicServiceListNamespacePipelinesVisibility.VISIBILITYPRIVATE => "VISIBILITY_PRIVATE",
                PipelinePublicServiceListNamespacePipelinesVisibility.VISIBILITYPUBLIC => "VISIBILITY_PUBLIC",
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
                "VISIBILITY_PRIVATE" => PipelinePublicServiceListNamespacePipelinesVisibility.VISIBILITYPRIVATE,
                "VISIBILITY_PUBLIC" => PipelinePublicServiceListNamespacePipelinesVisibility.VISIBILITYPUBLIC,
                _ => null,
            };
        }
    }
}