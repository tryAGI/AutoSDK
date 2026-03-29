//HintName: G.Models.TwilioPhoneNumberStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the phone number.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TwilioPhoneNumberStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="activating")]
        Activating,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blocked")]
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioPhoneNumberStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioPhoneNumberStatus value)
        {
            return value switch
            {
                TwilioPhoneNumberStatus.Activating => "activating",
                TwilioPhoneNumberStatus.Active => "active",
                TwilioPhoneNumberStatus.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioPhoneNumberStatus? ToEnum(string value)
        {
            return value switch
            {
                "activating" => TwilioPhoneNumberStatus.Activating,
                "active" => TwilioPhoneNumberStatus.Active,
                "blocked" => TwilioPhoneNumberStatus.Blocked,
                _ => null,
            };
        }
    }
}