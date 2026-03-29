//HintName: G.Models.SessionsUpdateRequestStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set to `REQUEST_RELEASE` to request that the session complete. Use before session's timeout to avoid additional charges.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SessionsUpdateRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="REQUEST_RELEASE")]
        RequestRelease,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionsUpdateRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsUpdateRequestStatus value)
        {
            return value switch
            {
                SessionsUpdateRequestStatus.RequestRelease => "REQUEST_RELEASE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsUpdateRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "REQUEST_RELEASE" => SessionsUpdateRequestStatus.RequestRelease,
                _ => null,
            };
        }
    }
}