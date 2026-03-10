//HintName: G.Models.PhoneNumberTransferCustomSipHeaderDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PhoneNumberTransferCustomSipHeaderDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dynamic")]
        Dynamic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="static")]
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberTransferCustomSipHeaderDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberTransferCustomSipHeaderDiscriminatorType value)
        {
            return value switch
            {
                PhoneNumberTransferCustomSipHeaderDiscriminatorType.Dynamic => "dynamic",
                PhoneNumberTransferCustomSipHeaderDiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberTransferCustomSipHeaderDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => PhoneNumberTransferCustomSipHeaderDiscriminatorType.Dynamic,
                "static" => PhoneNumberTransferCustomSipHeaderDiscriminatorType.Static,
                _ => null,
            };
        }
    }
}