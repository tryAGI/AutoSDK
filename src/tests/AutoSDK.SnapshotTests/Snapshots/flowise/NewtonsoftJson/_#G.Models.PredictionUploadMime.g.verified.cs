//HintName: G.Models.PredictionUploadMime.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The MIME type of the file or resource<br/>
    /// Example: image/png
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PredictionUploadMime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio/aac")]
        AudioAac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio/mp4")]
        AudioMp4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio/mpeg")]
        AudioMpeg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio/ogg")]
        AudioOgg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio/wav")]
        AudioWav,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio/webm")]
        AudioWebm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/gif")]
        ImageGif,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/jpeg")]
        ImageJpeg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/jpg")]
        ImageJpg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/png")]
        ImagePng,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/webp")]
        ImageWebp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionUploadMimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionUploadMime value)
        {
            return value switch
            {
                PredictionUploadMime.AudioAac => "audio/aac",
                PredictionUploadMime.AudioMp4 => "audio/mp4",
                PredictionUploadMime.AudioMpeg => "audio/mpeg",
                PredictionUploadMime.AudioOgg => "audio/ogg",
                PredictionUploadMime.AudioWav => "audio/wav",
                PredictionUploadMime.AudioWebm => "audio/webm",
                PredictionUploadMime.ImageGif => "image/gif",
                PredictionUploadMime.ImageJpeg => "image/jpeg",
                PredictionUploadMime.ImageJpg => "image/jpg",
                PredictionUploadMime.ImagePng => "image/png",
                PredictionUploadMime.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionUploadMime? ToEnum(string value)
        {
            return value switch
            {
                "audio/aac" => PredictionUploadMime.AudioAac,
                "audio/mp4" => PredictionUploadMime.AudioMp4,
                "audio/mpeg" => PredictionUploadMime.AudioMpeg,
                "audio/ogg" => PredictionUploadMime.AudioOgg,
                "audio/wav" => PredictionUploadMime.AudioWav,
                "audio/webm" => PredictionUploadMime.AudioWebm,
                "image/gif" => PredictionUploadMime.ImageGif,
                "image/jpeg" => PredictionUploadMime.ImageJpeg,
                "image/jpg" => PredictionUploadMime.ImageJpg,
                "image/png" => PredictionUploadMime.ImagePng,
                "image/webp" => PredictionUploadMime.ImageWebp,
                _ => null,
            };
        }
    }
}