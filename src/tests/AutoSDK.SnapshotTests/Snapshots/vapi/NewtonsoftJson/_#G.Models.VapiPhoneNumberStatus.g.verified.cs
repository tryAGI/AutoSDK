//HintName: G.Models.VapiPhoneNumberStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the phone number.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VapiPhoneNumberStatus
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
    public static class VapiPhoneNumberStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiPhoneNumberStatus value)
        {
            return value switch
            {
                VapiPhoneNumberStatus.Activating => "activating",
                VapiPhoneNumberStatus.Active => "active",
                VapiPhoneNumberStatus.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiPhoneNumberStatus? ToEnum(string value)
        {
            return value switch
            {
                "activating" => VapiPhoneNumberStatus.Activating,
                "active" => VapiPhoneNumberStatus.Active,
                "blocked" => VapiPhoneNumberStatus.Blocked,
                _ => null,
            };
        }
    }
}