//HintName: G.Models.ResponseFunctionCallOutputStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the item.
    /// </summary>
    public enum ResponseFunctionCallOutputStatus
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
    public static class ResponseFunctionCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFunctionCallOutputStatus value)
        {
            return value switch
            {
                ResponseFunctionCallOutputStatus.Completed => "completed",
                ResponseFunctionCallOutputStatus.InProgress => "in_progress",
                ResponseFunctionCallOutputStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFunctionCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponseFunctionCallOutputStatus.Completed,
                "in_progress" => ResponseFunctionCallOutputStatus.InProgress,
                "incomplete" => ResponseFunctionCallOutputStatus.Incomplete,
                _ => null,
            };
        }
    }
}