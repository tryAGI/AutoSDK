//HintName: G.Models.InputMessageStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of item. One of `in_progress`, `completed`, or<br/>
    /// `incomplete`. Populated when items are returned via API.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputMessageStatus
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
    public static class InputMessageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageStatus value)
        {
            return value switch
            {
                InputMessageStatus.InProgress => "in_progress",
                InputMessageStatus.Completed => "completed",
                InputMessageStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => InputMessageStatus.InProgress,
                "completed" => InputMessageStatus.Completed,
                "incomplete" => InputMessageStatus.Incomplete,
                _ => null,
            };
        }
    }
}