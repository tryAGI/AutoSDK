//HintName: G.Models.PurchaseNumberRequestCountryCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Country code (US or CA; contact support for others)<br/>
    /// Default Value: US
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PurchaseNumberRequestCountryCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CA")]
        Ca,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="US")]
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PurchaseNumberRequestCountryCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PurchaseNumberRequestCountryCode value)
        {
            return value switch
            {
                PurchaseNumberRequestCountryCode.Ca => "CA",
                PurchaseNumberRequestCountryCode.Us => "US",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PurchaseNumberRequestCountryCode? ToEnum(string value)
        {
            return value switch
            {
                "CA" => PurchaseNumberRequestCountryCode.Ca,
                "US" => PurchaseNumberRequestCountryCode.Us,
                _ => null,
            };
        }
    }
}