//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant4AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConnectedAccountsByNanoidResponseStateVariant4AuthScheme
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
    public static class GetConnectedAccountsByNanoidResponseStateVariant4AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant4AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant4AuthScheme.Basic => "BASIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant4AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BASIC" => GetConnectedAccountsByNanoidResponseStateVariant4AuthScheme.Basic,
                _ => null,
            };
        }
    }
}