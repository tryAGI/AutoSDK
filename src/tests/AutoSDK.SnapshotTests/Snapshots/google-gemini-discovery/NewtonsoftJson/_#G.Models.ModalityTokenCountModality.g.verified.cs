//HintName: G.Models.ModalityTokenCountModality.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The modality associated with this token count.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModalityTokenCountModality
    {
        /// <summary>
        /// Audio.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AUDIO")]
        Audio,
        /// <summary>
        /// Document, e.g. PDF.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DOCUMENT")]
        Document,
        /// <summary>
        /// Image.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IMAGE")]
        Image,
        /// <summary>
        /// Unspecified modality.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MODALITY_UNSPECIFIED")]
        ModalityUnspecified,
        /// <summary>
        /// Plain text.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TEXT")]
        Text,
        /// <summary>
        /// Video.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIDEO")]
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModalityTokenCountModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModalityTokenCountModality value)
        {
            return value switch
            {
                ModalityTokenCountModality.Audio => "AUDIO",
                ModalityTokenCountModality.Document => "DOCUMENT",
                ModalityTokenCountModality.Image => "IMAGE",
                ModalityTokenCountModality.ModalityUnspecified => "MODALITY_UNSPECIFIED",
                ModalityTokenCountModality.Text => "TEXT",
                ModalityTokenCountModality.Video => "VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModalityTokenCountModality? ToEnum(string value)
        {
            return value switch
            {
                "AUDIO" => ModalityTokenCountModality.Audio,
                "DOCUMENT" => ModalityTokenCountModality.Document,
                "IMAGE" => ModalityTokenCountModality.Image,
                "MODALITY_UNSPECIFIED" => ModalityTokenCountModality.ModalityUnspecified,
                "TEXT" => ModalityTokenCountModality.Text,
                "VIDEO" => ModalityTokenCountModality.Video,
                _ => null,
            };
        }
    }
}