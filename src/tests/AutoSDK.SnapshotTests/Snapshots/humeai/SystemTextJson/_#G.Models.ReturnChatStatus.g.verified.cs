//HintName: G.Models.ReturnChatStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReturnChatStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        MaxDurationTimeout,
        /// <summary>
        /// 
        /// </summary>
        UserEnded,
        /// <summary>
        /// 
        /// </summary>
        UserTimeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReturnChatStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReturnChatStatus value)
        {
            return value switch
            {
                ReturnChatStatus.Active => "ACTIVE",
                ReturnChatStatus.Error => "ERROR",
                ReturnChatStatus.MaxDurationTimeout => "MAX_DURATION_TIMEOUT",
                ReturnChatStatus.UserEnded => "USER_ENDED",
                ReturnChatStatus.UserTimeout => "USER_TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReturnChatStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => ReturnChatStatus.Active,
                "ERROR" => ReturnChatStatus.Error,
                "MAX_DURATION_TIMEOUT" => ReturnChatStatus.MaxDurationTimeout,
                "USER_ENDED" => ReturnChatStatus.UserEnded,
                "USER_TIMEOUT" => ReturnChatStatus.UserTimeout,
                _ => null,
            };
        }
    }
}