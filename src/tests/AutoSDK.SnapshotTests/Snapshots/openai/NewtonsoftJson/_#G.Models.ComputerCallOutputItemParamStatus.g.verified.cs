//HintName: G.Models.ComputerCallOutputItemParamStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the message input. One of `in_progress`, `completed`, or `incomplete`. Populated when input items are returned via API.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ComputerCallOutputItemParamStatus
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
    public static class ComputerCallOutputItemParamStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerCallOutputItemParamStatus value)
        {
            return value switch
            {
                ComputerCallOutputItemParamStatus.InProgress => "in_progress",
                ComputerCallOutputItemParamStatus.Completed => "completed",
                ComputerCallOutputItemParamStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerCallOutputItemParamStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ComputerCallOutputItemParamStatus.InProgress,
                "completed" => ComputerCallOutputItemParamStatus.Completed,
                "incomplete" => ComputerCallOutputItemParamStatus.Incomplete,
                _ => null,
            };
        }
    }
}