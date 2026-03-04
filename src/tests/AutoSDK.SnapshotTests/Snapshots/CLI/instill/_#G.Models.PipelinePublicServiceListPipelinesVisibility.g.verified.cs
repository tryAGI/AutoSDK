//HintName: G.Models.PipelinePublicServiceListPipelinesVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PipelinePublicServiceListPipelinesVisibility
    {
        /// <summary>
        /// Only the user can see the pipeline.
        /// </summary>
        VisibilityPrivate,
        /// <summary>
        /// Other users can see the pipeline.
        /// </summary>
        VisibilityPublic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PipelinePublicServiceListPipelinesVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PipelinePublicServiceListPipelinesVisibility value)
        {
            return value switch
            {
                PipelinePublicServiceListPipelinesVisibility.VisibilityPrivate => "VISIBILITY_PRIVATE",
                PipelinePublicServiceListPipelinesVisibility.VisibilityPublic => "VISIBILITY_PUBLIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PipelinePublicServiceListPipelinesVisibility? ToEnum(string value)
        {
            return value switch
            {
                "VISIBILITY_PRIVATE" => PipelinePublicServiceListPipelinesVisibility.VisibilityPrivate,
                "VISIBILITY_PUBLIC" => PipelinePublicServiceListPipelinesVisibility.VisibilityPublic,
                _ => null,
            };
        }
    }
}