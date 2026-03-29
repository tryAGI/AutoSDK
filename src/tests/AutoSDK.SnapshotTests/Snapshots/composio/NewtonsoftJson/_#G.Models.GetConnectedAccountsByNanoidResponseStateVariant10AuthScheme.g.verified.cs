//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant10AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConnectedAccountsByNanoidResponseStateVariant10AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASIC_WITH_JWT")]
        BasicWithJwt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsByNanoidResponseStateVariant10AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant10AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant10AuthScheme.BasicWithJwt => "BASIC_WITH_JWT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant10AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BASIC_WITH_JWT" => GetConnectedAccountsByNanoidResponseStateVariant10AuthScheme.BasicWithJwt,
                _ => null,
            };
        }
    }
}