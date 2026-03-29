//HintName: G.Models.AnnotationQueueObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnnotationQueueObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Observation,
        /// <summary>
        /// 
        /// </summary>
        Session,
        /// <summary>
        /// 
        /// </summary>
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationQueueObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationQueueObjectType value)
        {
            return value switch
            {
                AnnotationQueueObjectType.Observation => "OBSERVATION",
                AnnotationQueueObjectType.Session => "SESSION",
                AnnotationQueueObjectType.Trace => "TRACE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationQueueObjectType? ToEnum(string value)
        {
            return value switch
            {
                "OBSERVATION" => AnnotationQueueObjectType.Observation,
                "SESSION" => AnnotationQueueObjectType.Session,
                "TRACE" => AnnotationQueueObjectType.Trace,
                _ => null,
            };
        }
    }
}