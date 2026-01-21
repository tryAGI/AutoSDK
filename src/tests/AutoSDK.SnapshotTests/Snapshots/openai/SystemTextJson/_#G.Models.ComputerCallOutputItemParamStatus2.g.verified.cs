//HintName: G.Models.ComputerCallOutputItemParamStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the message input. One of `in_progress`, `completed`, or `incomplete`. Populated when input items are returned via API.
    /// </summary>
    public enum ComputerCallOutputItemParamStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerCallOutputItemParamStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerCallOutputItemParamStatus2 value)
        {
            return value switch
            {
                ComputerCallOutputItemParamStatus2.InProgress => "in_progress",
                ComputerCallOutputItemParamStatus2.Completed => "completed",
                ComputerCallOutputItemParamStatus2.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerCallOutputItemParamStatus2? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => ComputerCallOutputItemParamStatus2.InProgress,
                "completed" => ComputerCallOutputItemParamStatus2.Completed,
                "incomplete" => ComputerCallOutputItemParamStatus2.Incomplete,
                _ => null,
            };
        }
    }
}