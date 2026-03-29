//HintName: G.Models.OutputDatetimeItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputDatetimeItemStatus
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
    public static class OutputDatetimeItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputDatetimeItemStatus value)
        {
            return value switch
            {
                OutputDatetimeItemStatus.Completed => "completed",
                OutputDatetimeItemStatus.InProgress => "in_progress",
                OutputDatetimeItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputDatetimeItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OutputDatetimeItemStatus.Completed,
                "in_progress" => OutputDatetimeItemStatus.InProgress,
                "incomplete" => OutputDatetimeItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}