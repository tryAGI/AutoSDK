//HintName: G.Models.AnnotationQueueStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnnotationQueueStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETED")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PENDING")]
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationQueueStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationQueueStatus value)
        {
            return value switch
            {
                AnnotationQueueStatus.Completed => "COMPLETED",
                AnnotationQueueStatus.Pending => "PENDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationQueueStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => AnnotationQueueStatus.Completed,
                "PENDING" => AnnotationQueueStatus.Pending,
                _ => null,
            };
        }
    }
}