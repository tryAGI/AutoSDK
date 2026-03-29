//HintName: G.Models.VonagePhoneNumberStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the phone number.
    /// </summary>
    public enum VonagePhoneNumberStatus
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
    public static class VonagePhoneNumberStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VonagePhoneNumberStatus value)
        {
            return value switch
            {
                VonagePhoneNumberStatus.Activating => "activating",
                VonagePhoneNumberStatus.Active => "active",
                VonagePhoneNumberStatus.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VonagePhoneNumberStatus? ToEnum(string value)
        {
            return value switch
            {
                "activating" => VonagePhoneNumberStatus.Activating,
                "active" => VonagePhoneNumberStatus.Active,
                "blocked" => VonagePhoneNumberStatus.Blocked,
                _ => null,
            };
        }
    }
}