//HintName: G.Models.AnnotationQueueItemSchemaAnnotationState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnnotationQueueItemSchemaAnnotationState
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Unstarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationQueueItemSchemaAnnotationStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationQueueItemSchemaAnnotationState value)
        {
            return value switch
            {
                AnnotationQueueItemSchemaAnnotationState.Completed => "completed",
                AnnotationQueueItemSchemaAnnotationState.InProgress => "in_progress",
                AnnotationQueueItemSchemaAnnotationState.Skipped => "skipped",
                AnnotationQueueItemSchemaAnnotationState.Unstarted => "unstarted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationQueueItemSchemaAnnotationState? ToEnum(string value)
        {
            return value switch
            {
                "completed" => AnnotationQueueItemSchemaAnnotationState.Completed,
                "in_progress" => AnnotationQueueItemSchemaAnnotationState.InProgress,
                "skipped" => AnnotationQueueItemSchemaAnnotationState.Skipped,
                "unstarted" => AnnotationQueueItemSchemaAnnotationState.Unstarted,
                _ => null,
            };
        }
    }
}