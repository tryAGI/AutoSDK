//HintName: G.Models.AssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssetType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetType value)
        {
            return value switch
            {
                AssetType.Audio => "audio",
                AssetType.Image => "image",
                AssetType.Text => "text",
                AssetType.Video => "video",
                AssetType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => AssetType.Audio,
                "image" => AssetType.Image,
                "text" => AssetType.Text,
                "video" => AssetType.Video,
                "voice" => AssetType.Voice,
                _ => null,
            };
        }
    }
}