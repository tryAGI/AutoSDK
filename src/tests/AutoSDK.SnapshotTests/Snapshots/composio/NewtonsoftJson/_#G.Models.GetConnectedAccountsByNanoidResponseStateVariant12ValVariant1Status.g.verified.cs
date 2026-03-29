//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INITIALIZING")]
        Initializing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status.Initializing => "INITIALIZING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIALIZING" => GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1Status.Initializing,
                _ => null,
            };
        }
    }
}