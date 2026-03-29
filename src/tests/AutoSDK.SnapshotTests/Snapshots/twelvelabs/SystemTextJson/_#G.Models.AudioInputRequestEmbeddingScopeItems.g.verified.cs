//HintName: G.Models.AudioInputRequestEmbeddingScopeItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioInputRequestEmbeddingScopeItems
    {
        /// <summary>
        /// 
        /// </summary>
        Asset,
        /// <summary>
        /// 
        /// </summary>
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioInputRequestEmbeddingScopeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioInputRequestEmbeddingScopeItems value)
        {
            return value switch
            {
                AudioInputRequestEmbeddingScopeItems.Asset => "asset",
                AudioInputRequestEmbeddingScopeItems.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioInputRequestEmbeddingScopeItems? ToEnum(string value)
        {
            return value switch
            {
                "asset" => AudioInputRequestEmbeddingScopeItems.Asset,
                "clip" => AudioInputRequestEmbeddingScopeItems.Clip,
                _ => null,
            };
        }
    }
}