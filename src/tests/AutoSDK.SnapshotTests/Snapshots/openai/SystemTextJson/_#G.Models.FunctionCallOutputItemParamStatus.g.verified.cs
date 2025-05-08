//HintName: G.Models.FunctionCallOutputItemParamStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or `incomplete`. Populated when items are returned via API.
    /// </summary>
    public enum FunctionCallOutputItemParamStatus
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
    public static class FunctionCallOutputItemParamStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallOutputItemParamStatus value)
        {
            return value switch
            {
                FunctionCallOutputItemParamStatus.InProgress => "in_progress",
                FunctionCallOutputItemParamStatus.Completed => "completed",
                FunctionCallOutputItemParamStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallOutputItemParamStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => FunctionCallOutputItemParamStatus.InProgress,
                "completed" => FunctionCallOutputItemParamStatus.Completed,
                "incomplete" => FunctionCallOutputItemParamStatus.Incomplete,
                _ => null,
            };
        }
    }
}