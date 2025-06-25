//HintName: G.Models.GetConversationResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConversationResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Initiated,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConversationResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConversationResponseModelStatus value)
        {
            return value switch
            {
                GetConversationResponseModelStatus.Initiated => "initiated",
                GetConversationResponseModelStatus.InProgress => "in-progress",
                GetConversationResponseModelStatus.Processing => "processing",
                GetConversationResponseModelStatus.Done => "done",
                GetConversationResponseModelStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConversationResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "initiated" => GetConversationResponseModelStatus.Initiated,
                "in-progress" => GetConversationResponseModelStatus.InProgress,
                "processing" => GetConversationResponseModelStatus.Processing,
                "done" => GetConversationResponseModelStatus.Done,
                "failed" => GetConversationResponseModelStatus.Failed,
                _ => null,
            };
        }
    }
}