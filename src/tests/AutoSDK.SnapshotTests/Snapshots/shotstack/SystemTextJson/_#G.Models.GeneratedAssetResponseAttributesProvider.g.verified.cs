//HintName: G.Models.GeneratedAssetResponseAttributesProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The native or third party provider that generated the asset, `shotstack`, `elevenlabs`, `heygen` or `d-id`.
    /// </summary>
    public enum GeneratedAssetResponseAttributesProvider
    {
        /// <summary>
        /// 
        /// </summary>
        DId,
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        Heygen,
        /// <summary>
        /// 
        /// </summary>
        Shotstack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeneratedAssetResponseAttributesProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeneratedAssetResponseAttributesProvider value)
        {
            return value switch
            {
                GeneratedAssetResponseAttributesProvider.DId => "d-id",
                GeneratedAssetResponseAttributesProvider.Elevenlabs => "elevenlabs",
                GeneratedAssetResponseAttributesProvider.Heygen => "heygen",
                GeneratedAssetResponseAttributesProvider.Shotstack => "shotstack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeneratedAssetResponseAttributesProvider? ToEnum(string value)
        {
            return value switch
            {
                "d-id" => GeneratedAssetResponseAttributesProvider.DId,
                "elevenlabs" => GeneratedAssetResponseAttributesProvider.Elevenlabs,
                "heygen" => GeneratedAssetResponseAttributesProvider.Heygen,
                "shotstack" => GeneratedAssetResponseAttributesProvider.Shotstack,
                _ => null,
            };
        }
    }
}