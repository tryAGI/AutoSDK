//HintName: G.Models.LocalShellToolCallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the local shell call.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LocalShellToolCallStatus
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
    public static class LocalShellToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LocalShellToolCallStatus value)
        {
            return value switch
            {
                LocalShellToolCallStatus.InProgress => "in_progress",
                LocalShellToolCallStatus.Completed => "completed",
                LocalShellToolCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LocalShellToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => LocalShellToolCallStatus.InProgress,
                "completed" => LocalShellToolCallStatus.Completed,
                "incomplete" => LocalShellToolCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}