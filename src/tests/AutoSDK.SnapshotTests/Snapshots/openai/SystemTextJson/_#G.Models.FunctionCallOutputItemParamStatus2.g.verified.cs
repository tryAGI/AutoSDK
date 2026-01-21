//HintName: G.Models.FunctionCallOutputItemParamStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or `incomplete`. Populated when items are returned via API.
    /// </summary>
    public enum FunctionCallOutputItemParamStatus2
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
    public static class FunctionCallOutputItemParamStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallOutputItemParamStatus2 value)
        {
            return value switch
            {
                FunctionCallOutputItemParamStatus2.InProgress => "in_progress",
                FunctionCallOutputItemParamStatus2.Completed => "completed",
                FunctionCallOutputItemParamStatus2.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallOutputItemParamStatus2? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => FunctionCallOutputItemParamStatus2.InProgress,
                "completed" => FunctionCallOutputItemParamStatus2.Completed,
                "incomplete" => FunctionCallOutputItemParamStatus2.Incomplete,
                _ => null,
            };
        }
    }
}