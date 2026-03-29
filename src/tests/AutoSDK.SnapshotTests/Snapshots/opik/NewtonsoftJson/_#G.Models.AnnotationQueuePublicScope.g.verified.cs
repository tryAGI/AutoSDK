//HintName: G.Models.AnnotationQueuePublicScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnnotationQueuePublicScope
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
    public static class AnnotationQueuePublicScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationQueuePublicScope value)
        {
            return value switch
            {
                AnnotationQueuePublicScope.Thread => "thread",
                AnnotationQueuePublicScope.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationQueuePublicScope? ToEnum(string value)
        {
            return value switch
            {
                "thread" => AnnotationQueuePublicScope.Thread,
                "trace" => AnnotationQueuePublicScope.Trace,
                _ => null,
            };
        }
    }
}