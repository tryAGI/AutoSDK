//HintName: G.Models.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GenerateAssetPublicGenerationsPostResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio_from_video")]
        AudioFromVideo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio_isolation")]
        AudioIsolation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_to_image")]
        ImageToImage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_upscale")]
        ImageUpscale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="motion_control")]
        MotionControl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speech_to_speech")]
        SpeechToSpeech,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_to_sound")]
        TextToSound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_to_speech")]
        TextToSpeech,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video_to_video")]
        VideoToVideo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video_upscale")]
        VideoUpscale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video_with_audio")]
        VideoWithAudio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice_clone")]
        VoiceClone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateAssetPublicGenerationsPostResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateAssetPublicGenerationsPostResponseDiscriminatorType value)
        {
            return value switch
            {
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.AudioFromVideo => "audio_from_video",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.AudioIsolation => "audio_isolation",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Image => "image",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.ImageToImage => "image_to_image",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.ImageUpscale => "image_upscale",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.MotionControl => "motion_control",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.SpeechToSpeech => "speech_to_speech",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSound => "text_to_sound",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSpeech => "text_to_speech",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Video => "video",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoToVideo => "video_to_video",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoUpscale => "video_upscale",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoWithAudio => "video_with_audio",
                GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VoiceClone => "voice_clone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_from_video" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.AudioFromVideo,
                "audio_isolation" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.AudioIsolation,
                "image" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Image,
                "image_to_image" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.ImageToImage,
                "image_upscale" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.ImageUpscale,
                "motion_control" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.MotionControl,
                "speech_to_speech" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.SpeechToSpeech,
                "text_to_sound" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSound,
                "text_to_speech" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSpeech,
                "video" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Video,
                "video_to_video" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoToVideo,
                "video_upscale" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoUpscale,
                "video_with_audio" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoWithAudio,
                "voice_clone" => GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VoiceClone,
                _ => null,
            };
        }
    }
}