//HintName: G.Models.LocalShellToolCallOutputStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or `incomplete`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LocalShellToolCallOutputStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="incomplete")]
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LocalShellToolCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalShellToolCallOutputStatus value)
        {
            return value switch
            {
                LocalShellToolCallOutputStatus.InProgress => "in_progress",
                LocalShellToolCallOutputStatus.Completed => "completed",
                LocalShellToolCallOutputStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalShellToolCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => LocalShellToolCallOutputStatus.InProgress,
                "completed" => LocalShellToolCallOutputStatus.Completed,
                "incomplete" => LocalShellToolCallOutputStatus.Incomplete,
                _ => null,
            };
        }
    }
}