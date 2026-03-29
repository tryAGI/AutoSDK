//HintName: G.Models.AssetDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssetDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Caption,
        /// <summary>
        /// 
        /// </summary>
        Html,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        ImageToVideo,
        /// <summary>
        /// 
        /// </summary>
        Luma,
        /// <summary>
        /// 
        /// </summary>
        RichCaption,
        /// <summary>
        /// 
        /// </summary>
        RichText,
        /// <summary>
        /// 
        /// </summary>
        Shape,
        /// <summary>
        /// 
        /// </summary>
        Svg,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        TextToImage,
        /// <summary>
        /// 
        /// </summary>
        TextToSpeech,
        /// <summary>
        /// 
        /// </summary>
        Title,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetDiscriminatorType value)
        {
            return value switch
            {
                AssetDiscriminatorType.Audio => "audio",
                AssetDiscriminatorType.Caption => "caption",
                AssetDiscriminatorType.Html => "html",
                AssetDiscriminatorType.Image => "image",
                AssetDiscriminatorType.ImageToVideo => "image-to-video",
                AssetDiscriminatorType.Luma => "luma",
                AssetDiscriminatorType.RichCaption => "rich-caption",
                AssetDiscriminatorType.RichText => "rich-text",
                AssetDiscriminatorType.Shape => "shape",
                AssetDiscriminatorType.Svg => "svg",
                AssetDiscriminatorType.Text => "text",
                AssetDiscriminatorType.TextToImage => "text-to-image",
                AssetDiscriminatorType.TextToSpeech => "text-to-speech",
                AssetDiscriminatorType.Title => "title",
                AssetDiscriminatorType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => AssetDiscriminatorType.Audio,
                "caption" => AssetDiscriminatorType.Caption,
                "html" => AssetDiscriminatorType.Html,
                "image" => AssetDiscriminatorType.Image,
                "image-to-video" => AssetDiscriminatorType.ImageToVideo,
                "luma" => AssetDiscriminatorType.Luma,
                "rich-caption" => AssetDiscriminatorType.RichCaption,
                "rich-text" => AssetDiscriminatorType.RichText,
                "shape" => AssetDiscriminatorType.Shape,
                "svg" => AssetDiscriminatorType.Svg,
                "text" => AssetDiscriminatorType.Text,
                "text-to-image" => AssetDiscriminatorType.TextToImage,
                "text-to-speech" => AssetDiscriminatorType.TextToSpeech,
                "title" => AssetDiscriminatorType.Title,
                "video" => AssetDiscriminatorType.Video,
                _ => null,
            };
        }
    }
}