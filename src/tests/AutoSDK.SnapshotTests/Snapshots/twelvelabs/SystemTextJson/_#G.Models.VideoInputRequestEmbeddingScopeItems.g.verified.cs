//HintName: G.Models.VideoInputRequestEmbeddingScopeItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoInputRequestEmbeddingScopeItems
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
    public static class VideoInputRequestEmbeddingScopeItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoInputRequestEmbeddingScopeItems value)
        {
            return value switch
            {
                VideoInputRequestEmbeddingScopeItems.Asset => "asset",
                VideoInputRequestEmbeddingScopeItems.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoInputRequestEmbeddingScopeItems? ToEnum(string value)
        {
            return value switch
            {
                "asset" => VideoInputRequestEmbeddingScopeItems.Asset,
                "clip" => VideoInputRequestEmbeddingScopeItems.Clip,
                _ => null,
            };
        }
    }
}