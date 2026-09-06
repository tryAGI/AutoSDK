//HintName: G.Models.ComputerCallOutputItemParamStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the message input. One of `in_progress`, `completed`, or `incomplete`. Populated when input items are returned via API.
    /// </summary>
    public enum ComputerCallOutputItemParamStatus
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
    public static class ComputerCallOutputItemParamStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerCallOutputItemParamStatus value)
        {
            return value switch
            {
                ComputerCallOutputItemParamStatus.Completed => "completed",
                ComputerCallOutputItemParamStatus.InProgress => "in_progress",
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
                "completed" => ComputerCallOutputItemParamStatus.Completed,
                "in_progress" => ComputerCallOutputItemParamStatus.InProgress,
                "incomplete" => ComputerCallOutputItemParamStatus.Incomplete,
                _ => null,
            };
        }
    }
}