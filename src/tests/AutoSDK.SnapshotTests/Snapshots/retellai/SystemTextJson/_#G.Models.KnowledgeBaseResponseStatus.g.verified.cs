//HintName: G.Models.KnowledgeBaseResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the knowledge base. When it's created and being processed, it's "in_progress". When the processing is done, it's "complete". When there's an error in processing, it's "error". When it is during kb updating, it's "refreshing_in_progress".<br/>
    /// Example: in_progress
    /// </summary>
    public enum KnowledgeBaseResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        RefreshingInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseResponseStatus value)
        {
            return value switch
            {
                KnowledgeBaseResponseStatus.Complete => "complete",
                KnowledgeBaseResponseStatus.Error => "error",
                KnowledgeBaseResponseStatus.InProgress => "in_progress",
                KnowledgeBaseResponseStatus.RefreshingInProgress => "refreshing_in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => KnowledgeBaseResponseStatus.Complete,
                "error" => KnowledgeBaseResponseStatus.Error,
                "in_progress" => KnowledgeBaseResponseStatus.InProgress,
                "refreshing_in_progress" => KnowledgeBaseResponseStatus.RefreshingInProgress,
                _ => null,
            };
        }
    }
}