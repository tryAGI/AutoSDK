//HintName: G.Models.PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Dynamic,
        /// <summary>
        /// 
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberTransferPostDialDigitsVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType value)
        {
            return value switch
            {
                PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType.Dynamic => "dynamic",
                PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType.Dynamic,
                "static" => PhoneNumberTransferPostDialDigitsVariant1DiscriminatorType.Static,
                _ => null,
            };
        }
    }
}