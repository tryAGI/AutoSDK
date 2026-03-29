//HintName: G.Models.EventReadResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the event.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EventReadResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PENDING")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
        Running,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCEEDED")]
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventReadResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventReadResponseStatus value)
        {
            return value switch
            {
                EventReadResponseStatus.Failed => "FAILED",
                EventReadResponseStatus.Pending => "PENDING",
                EventReadResponseStatus.Running => "RUNNING",
                EventReadResponseStatus.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventReadResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => EventReadResponseStatus.Failed,
                "PENDING" => EventReadResponseStatus.Pending,
                "RUNNING" => EventReadResponseStatus.Running,
                "SUCCEEDED" => EventReadResponseStatus.Succeeded,
                _ => null,
            };
        }
    }
}