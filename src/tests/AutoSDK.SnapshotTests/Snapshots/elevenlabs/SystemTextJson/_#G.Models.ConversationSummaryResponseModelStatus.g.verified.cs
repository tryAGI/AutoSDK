//HintName: G.Models.ConversationSummaryResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationSummaryResponseModelStatus
    {
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
    public static class ConversationSummaryResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationSummaryResponseModelStatus value)
        {
            return value switch
            {
                ConversationSummaryResponseModelStatus.Processing => "processing",
                ConversationSummaryResponseModelStatus.Done => "done",
                ConversationSummaryResponseModelStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationSummaryResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "processing" => ConversationSummaryResponseModelStatus.Processing,
                "done" => ConversationSummaryResponseModelStatus.Done,
                "failed" => ConversationSummaryResponseModelStatus.Failed,
                _ => null,
            };
        }
    }
}