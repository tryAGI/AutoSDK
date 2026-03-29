//HintName: G.Models.ToolCallStatusEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolCallStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
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