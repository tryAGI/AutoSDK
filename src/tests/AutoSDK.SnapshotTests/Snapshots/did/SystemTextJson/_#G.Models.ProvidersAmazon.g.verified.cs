//HintName: G.Models.ProvidersAmazon.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProvidersAmazon
    {
        /// <summary>
        /// 
        /// </summary>
        Amazon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProvidersAmazonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProvidersAmazon value)
        {
            return value switch
            {
                ProvidersAmazon.Amazon => "amazon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProvidersAmazon? ToEnum(string value)
        {
            return value switch
            {
                "amazon" => ProvidersAmazon.Amazon,
                _ => null,
            };
        }
    }
}