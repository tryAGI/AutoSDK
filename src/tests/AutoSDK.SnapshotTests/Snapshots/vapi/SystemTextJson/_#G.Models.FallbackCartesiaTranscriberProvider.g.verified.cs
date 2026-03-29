//HintName: G.Models.FallbackCartesiaTranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FallbackCartesiaTranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackCartesiaTranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackCartesiaTranscriberProvider value)
        {
            return value switch
            {
                FallbackCartesiaTranscriberProvider.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackCartesiaTranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => FallbackCartesiaTranscriberProvider.Cartesia,
                _ => null,
            };
        }
    }
}