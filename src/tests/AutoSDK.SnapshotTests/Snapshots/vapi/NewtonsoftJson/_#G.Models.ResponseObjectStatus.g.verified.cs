//HintName: G.Models.ResponseObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the response
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
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
    public static class ResponseObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseObjectStatus value)
        {
            return value switch
            {
                ResponseObjectStatus.Completed => "completed",
                ResponseObjectStatus.Failed => "failed",
                ResponseObjectStatus.InProgress => "in_progress",
                ResponseObjectStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseObjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponseObjectStatus.Completed,
                "failed" => ResponseObjectStatus.Failed,
                "in_progress" => ResponseObjectStatus.InProgress,
                "incomplete" => ResponseObjectStatus.Incomplete,
                _ => null,
            };
        }
    }
}