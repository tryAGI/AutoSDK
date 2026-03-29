//HintName: G.Models.GenerationConfigResponseModalitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerationConfigResponseModalitie
    {
        /// <summary>
        /// Indicates the model should return audio.
        /// </summary>
        Audio,
        /// <summary>
        /// Indicates the model should return images.
        /// </summary>
        Image,
        /// <summary>
        /// Default value.
        /// </summary>
        ModalityUnspecified,
        /// <summary>
        /// Indicates the model should return text.
        /// </summary>
        Text,
        /// <summary>
        /// Indicates the model should return video.
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationConfigResponseModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationConfigResponseModalitie value)
        {
            return value switch
            {
                GenerationConfigResponseModalitie.Audio => "AUDIO",
                GenerationConfigResponseModalitie.Image => "IMAGE",
                GenerationConfigResponseModalitie.ModalityUnspecified => "MODALITY_UNSPECIFIED",
                GenerationConfigResponseModalitie.Text => "TEXT",
                GenerationConfigResponseModalitie.Video => "VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationConfigResponseModalitie? ToEnum(string value)
        {
            return value switch
            {
                "AUDIO" => GenerationConfigResponseModalitie.Audio,
                "IMAGE" => GenerationConfigResponseModalitie.Image,
                "MODALITY_UNSPECIFIED" => GenerationConfigResponseModalitie.ModalityUnspecified,
                "TEXT" => GenerationConfigResponseModalitie.Text,
                "VIDEO" => GenerationConfigResponseModalitie.Video,
                _ => null,
            };
        }
    }
}