//HintName: G.Models.ResponseVariant3Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the response generation. One of `completed`, `failed`, <br/>
    /// `in_progress`, `cancelled`, `queued`, or `incomplete`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseVariant3Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="incomplete")]
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant3Status value)
        {
            return value switch
            {
                ResponseVariant3Status.Completed => "completed",
                ResponseVariant3Status.Failed => "failed",
                ResponseVariant3Status.InProgress => "in_progress",
                ResponseVariant3Status.Cancelled => "cancelled",
                ResponseVariant3Status.Queued => "queued",
                ResponseVariant3Status.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponseVariant3Status.Completed,
                "failed" => ResponseVariant3Status.Failed,
                "in_progress" => ResponseVariant3Status.InProgress,
                "cancelled" => ResponseVariant3Status.Cancelled,
                "queued" => ResponseVariant3Status.Queued,
                "incomplete" => ResponseVariant3Status.Incomplete,
                _ => null,
            };
        }
    }
}