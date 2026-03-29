//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant4AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConnectedAccountsResponseItemStateVariant4AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASIC")]
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant4AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant4AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant4AuthScheme.Basic => "BASIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant4AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BASIC" => GetConnectedAccountsResponseItemStateVariant4AuthScheme.Basic,
                _ => null,
            };
        }
    }
}