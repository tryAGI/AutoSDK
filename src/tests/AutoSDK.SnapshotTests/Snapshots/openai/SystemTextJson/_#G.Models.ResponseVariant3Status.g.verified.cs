//HintName: G.Models.ResponseVariant3Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the response generation. One of `completed`, `failed`, <br/>
    /// `in_progress`, `cancelled`, `queued`, or `incomplete`.
    /// </summary>
    public enum ResponseVariant3Status
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        Queued,
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
                ResponseVariant3Status.Cancelled => "cancelled",
                ResponseVariant3Status.Completed => "completed",
                ResponseVariant3Status.Failed => "failed",
                ResponseVariant3Status.InProgress => "in_progress",
                ResponseVariant3Status.Incomplete => "incomplete",
                ResponseVariant3Status.Queued => "queued",
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
                "cancelled" => ResponseVariant3Status.Cancelled,
                "completed" => ResponseVariant3Status.Completed,
                "failed" => ResponseVariant3Status.Failed,
                "in_progress" => ResponseVariant3Status.InProgress,
                "incomplete" => ResponseVariant3Status.Incomplete,
                "queued" => ResponseVariant3Status.Queued,
                _ => null,
            };
        }
    }
}