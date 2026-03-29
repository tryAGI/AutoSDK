//HintName: G.Models.ToolCallStatusEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolCallStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallStatusEnum value)
        {
            return value switch
            {
                ToolCallStatusEnum.Completed => "completed",
                ToolCallStatusEnum.InProgress => "in_progress",
                ToolCallStatusEnum.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ToolCallStatusEnum.Completed,
                "in_progress" => ToolCallStatusEnum.InProgress,
                "incomplete" => ToolCallStatusEnum.Incomplete,
                _ => null,
            };
        }
    }
}