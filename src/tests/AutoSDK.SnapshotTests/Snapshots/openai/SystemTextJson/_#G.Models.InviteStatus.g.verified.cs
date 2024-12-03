//HintName: G.Models.InviteStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `accepted`,`expired`, or `pending`
    /// </summary>
    public enum InviteStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InviteStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InviteStatus value)
        {
            return value switch
            {
                InviteStatus.Accepted => "accepted",
                InviteStatus.Expired => "expired",
                InviteStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InviteStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => InviteStatus.Accepted,
                "expired" => InviteStatus.Expired,
                "pending" => InviteStatus.Pending,
                _ => null,
            };
        }
    }
}