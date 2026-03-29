//HintName: G.Models.OutputItemReasoningStatus0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputItemReasoningStatus0
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemReasoningStatus0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemReasoningStatus0 value)
        {
            return value switch
            {
                OutputItemReasoningStatus0.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemReasoningStatus0? ToEnum(string value)
        {
            return value switch
            {
                "completed" => OutputItemReasoningStatus0.Completed,
                _ => null,
            };
        }
    }
}