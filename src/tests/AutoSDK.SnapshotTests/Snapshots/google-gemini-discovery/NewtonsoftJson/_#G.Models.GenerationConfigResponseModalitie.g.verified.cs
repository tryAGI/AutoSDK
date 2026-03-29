//HintName: G.Models.GenerationConfigResponseModalitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GenerationConfigResponseModalitie
    {
        /// <summary>
        /// Indicates the model should return audio.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AUDIO")]
        Audio,
        /// <summary>
        /// Indicates the model should return images.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IMAGE")]
        Image,
        /// <summary>
        /// Default value.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MODALITY_UNSPECIFIED")]
        ModalityUnspecified,
        /// <summary>
        /// Indicates the model should return text.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TEXT")]
        Text,
        /// <summary>
        /// Indicates the model should return video.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIDEO")]
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