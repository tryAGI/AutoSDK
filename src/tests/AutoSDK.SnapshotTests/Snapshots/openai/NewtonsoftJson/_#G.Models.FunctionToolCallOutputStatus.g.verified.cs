//HintName: G.Models.FunctionToolCallOutputStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the item. One of `in_progress`, `completed`, or<br/>
    /// `incomplete`. Populated when items are returned via API.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionToolCallOutputStatus
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
    public static class FunctionToolCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionToolCallOutputStatus value)
        {
            return value switch
            {
                FunctionToolCallOutputStatus.InProgress => "in_progress",
                FunctionToolCallOutputStatus.Completed => "completed",
                FunctionToolCallOutputStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionToolCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => FunctionToolCallOutputStatus.InProgress,
                "completed" => FunctionToolCallOutputStatus.Completed,
                "incomplete" => FunctionToolCallOutputStatus.Incomplete,
                _ => null,
            };
        }
    }
}