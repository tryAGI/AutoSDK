//HintName: G.Models.ByoPhoneNumberStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the phone number.
    /// </summary>
    public enum ByoPhoneNumberStatus
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
    public static class ByoPhoneNumberStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ByoPhoneNumberStatus value)
        {
            return value switch
            {
                ByoPhoneNumberStatus.Activating => "activating",
                ByoPhoneNumberStatus.Active => "active",
                ByoPhoneNumberStatus.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ByoPhoneNumberStatus? ToEnum(string value)
        {
            return value switch
            {
                "activating" => ByoPhoneNumberStatus.Activating,
                "active" => ByoPhoneNumberStatus.Active,
                "blocked" => ByoPhoneNumberStatus.Blocked,
                _ => null,
            };
        }
    }
}