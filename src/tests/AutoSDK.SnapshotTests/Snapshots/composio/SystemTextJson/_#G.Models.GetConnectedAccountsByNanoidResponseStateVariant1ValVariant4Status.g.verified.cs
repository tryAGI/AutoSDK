//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4Status
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4Status value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4Status.Failed => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4Status? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4Status.Failed,
                _ => null,
            };
        }
    }
}