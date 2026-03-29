//HintName: G.Models.OpenAIResponsesResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIResponsesResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
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
        [global::System.Runtime.Serialization.EnumMember(Value="incomplete")]
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesResponseStatus value)
        {
            return value switch
            {
                OpenAIResponsesResponseStatus.Cancelled => "cancelled",
                OpenAIResponsesResponseStatus.Completed => "completed",
                OpenAIResponsesResponseStatus.Failed => "failed",
                OpenAIResponsesResponseStatus.InProgress => "in_progress",
                OpenAIResponsesResponseStatus.Incomplete => "incomplete",
                OpenAIResponsesResponseStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => OpenAIResponsesResponseStatus.Cancelled,
                "completed" => OpenAIResponsesResponseStatus.Completed,
                "failed" => OpenAIResponsesResponseStatus.Failed,
                "in_progress" => OpenAIResponsesResponseStatus.InProgress,
                "incomplete" => OpenAIResponsesResponseStatus.Incomplete,
                "queued" => OpenAIResponsesResponseStatus.Queued,
                _ => null,
            };
        }
    }
}