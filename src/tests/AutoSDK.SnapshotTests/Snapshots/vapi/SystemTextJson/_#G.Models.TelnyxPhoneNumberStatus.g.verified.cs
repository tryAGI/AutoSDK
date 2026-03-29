//HintName: G.Models.TelnyxPhoneNumberStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the phone number.
    /// </summary>
    public enum TelnyxPhoneNumberStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Activating,
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TelnyxPhoneNumberStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TelnyxPhoneNumberStatus value)
        {
            return value switch
            {
                TelnyxPhoneNumberStatus.Activating => "activating",
                TelnyxPhoneNumberStatus.Active => "active",
                TelnyxPhoneNumberStatus.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TelnyxPhoneNumberStatus? ToEnum(string value)
        {
            return value switch
            {
                "activating" => TelnyxPhoneNumberStatus.Activating,
                "active" => TelnyxPhoneNumberStatus.Active,
                "blocked" => TelnyxPhoneNumberStatus.Blocked,
                _ => null,
            };
        }
    }
}