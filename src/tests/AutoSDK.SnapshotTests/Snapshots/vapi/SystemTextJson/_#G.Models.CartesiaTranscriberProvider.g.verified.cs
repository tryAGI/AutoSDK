//HintName: G.Models.CartesiaTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CartesiaTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CartesiaTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CartesiaTranscriberProvider value)
        {
            return value switch
            {
                CartesiaTranscriberProvider.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CartesiaTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => CartesiaTranscriberProvider.Cartesia,
                _ => null,
            };
        }
    }
}