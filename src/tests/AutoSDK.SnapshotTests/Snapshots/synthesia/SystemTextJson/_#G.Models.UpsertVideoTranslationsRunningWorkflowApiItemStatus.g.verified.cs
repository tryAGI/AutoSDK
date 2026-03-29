//HintName: G.Models.UpsertVideoTranslationsRunningWorkflowApiItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: in_progress
    /// </summary>
    public enum UpsertVideoTranslationsRunningWorkflowApiItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpsertVideoTranslationsRunningWorkflowApiItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpsertVideoTranslationsRunningWorkflowApiItemStatus value)
        {
            return value switch
            {
                UpsertVideoTranslationsRunningWorkflowApiItemStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpsertVideoTranslationsRunningWorkflowApiItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => UpsertVideoTranslationsRunningWorkflowApiItemStatus.InProgress,
                _ => null,
            };
        }
    }
}