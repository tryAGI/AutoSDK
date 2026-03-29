//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4Status
    {
        /// <summary>
        /// 
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4Status value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4Status.Inactive => "INACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4Status? ToEnum(string value)
        {
            return value switch
            {
                "INACTIVE" => GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4Status.Inactive,
                _ => null,
            };
        }
    }
}