//HintName: G.Models.UpdateStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `Acknowledged` - Request is saved to WAL and will be process in a queue. `Completed` - Request is completed, changes are actual. `WaitTimeout` - Request is waiting for timeout.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="acknowledged")]
        Acknowledged,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wait_timeout")]
        WaitTimeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateStatus value)
        {
            return value switch
            {
                UpdateStatus.Acknowledged => "acknowledged",
                UpdateStatus.Completed => "completed",
                UpdateStatus.WaitTimeout => "wait_timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "acknowledged" => UpdateStatus.Acknowledged,
                "completed" => UpdateStatus.Completed,
                "wait_timeout" => UpdateStatus.WaitTimeout,
                _ => null,
            };
        }
    }
}