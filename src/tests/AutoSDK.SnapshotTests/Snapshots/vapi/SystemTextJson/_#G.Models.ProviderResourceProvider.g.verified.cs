//HintName: G.Models.ProviderResourceProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider that manages this resource.
    /// </summary>
    public enum ProviderResourceProvider
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
    public static class ProviderResourceProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResourceProvider value)
        {
            return value switch
            {
                ProviderResourceProvider.x11labs => "11labs",
                ProviderResourceProvider.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResourceProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => ProviderResourceProvider.x11labs,
                "cartesia" => ProviderResourceProvider.Cartesia,
                _ => null,
            };
        }
    }
}