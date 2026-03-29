//HintName: G.Models.ProviderResourceControllerUpdateProviderResourceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProviderResourceControllerUpdateProviderResourceProvider
    {
        /// <summary>
        /// 
        /// </summary>
        x11labs,
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderResourceControllerUpdateProviderResourceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResourceControllerUpdateProviderResourceProvider value)
        {
            return value switch
            {
                ProviderResourceControllerUpdateProviderResourceProvider.x11labs => "11labs",
                ProviderResourceControllerUpdateProviderResourceProvider.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResourceControllerUpdateProviderResourceProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => ProviderResourceControllerUpdateProviderResourceProvider.x11labs,
                "cartesia" => ProviderResourceControllerUpdateProviderResourceProvider.Cartesia,
                _ => null,
            };
        }
    }
}