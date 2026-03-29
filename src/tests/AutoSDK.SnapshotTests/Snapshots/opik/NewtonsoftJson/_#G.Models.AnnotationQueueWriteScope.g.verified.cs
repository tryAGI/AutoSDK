//HintName: G.Models.AnnotationQueueWriteScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnnotationQueueWriteScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread")]
        Thread,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace")]
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationQueueWriteScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationQueueWriteScope value)
        {
            return value switch
            {
                AnnotationQueueWriteScope.Thread => "thread",
                AnnotationQueueWriteScope.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationQueueWriteScope? ToEnum(string value)
        {
            return value switch
            {
                "thread" => AnnotationQueueWriteScope.Thread,
                "trace" => AnnotationQueueWriteScope.Trace,
                _ => null,
            };
        }
    }
}