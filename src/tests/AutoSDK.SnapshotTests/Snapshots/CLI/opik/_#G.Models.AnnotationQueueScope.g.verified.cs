//HintName: G.Models.AnnotationQueueScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnnotationQueueScope
    {
        /// <summary>
        /// 
        /// </summary>
        Thread,
        /// <summary>
        /// 
        /// </summary>
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationQueueScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationQueueScope value)
        {
            return value switch
            {
                AnnotationQueueScope.Thread => "thread",
                AnnotationQueueScope.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationQueueScope? ToEnum(string value)
        {
            return value switch
            {
                "thread" => AnnotationQueueScope.Thread,
                "trace" => AnnotationQueueScope.Trace,
                _ => null,
            };
        }
    }
}