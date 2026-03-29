//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ACTIVE")]
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3Status value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3Status.Active => "ACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3Status.Active,
                _ => null,
            };
        }
    }
}