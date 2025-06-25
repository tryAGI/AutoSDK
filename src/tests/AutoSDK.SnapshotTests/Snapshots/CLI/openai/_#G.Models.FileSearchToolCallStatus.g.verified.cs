//HintName: G.Models.FileSearchToolCallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the file search tool call. One of `in_progress`, <br/>
    /// `searching`, `incomplete` or `failed`,
    /// </summary>
    public enum FileSearchToolCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Searching,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileSearchToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSearchToolCallStatus value)
        {
            return value switch
            {
                FileSearchToolCallStatus.InProgress => "in_progress",
                FileSearchToolCallStatus.Searching => "searching",
                FileSearchToolCallStatus.Completed => "completed",
                FileSearchToolCallStatus.Incomplete => "incomplete",
                FileSearchToolCallStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSearchToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => FileSearchToolCallStatus.InProgress,
                "searching" => FileSearchToolCallStatus.Searching,
                "completed" => FileSearchToolCallStatus.Completed,
                "incomplete" => FileSearchToolCallStatus.Incomplete,
                "failed" => FileSearchToolCallStatus.Failed,
                _ => null,
            };
        }
    }
}