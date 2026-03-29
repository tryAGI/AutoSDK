//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        Initializing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1Status value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1Status.Initializing => "INITIALIZING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIALIZING" => GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1Status.Initializing,
                _ => null,
            };
        }
    }
}