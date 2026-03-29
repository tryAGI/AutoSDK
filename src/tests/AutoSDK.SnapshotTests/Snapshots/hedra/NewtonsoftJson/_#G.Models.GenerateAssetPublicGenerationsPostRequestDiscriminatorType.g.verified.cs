//HintName: G.Models.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GenerateAssetPublicGenerationsPostRequestDiscriminatorType
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
    public static class GenerateAssetPublicGenerationsPostRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateAssetPublicGenerationsPostRequestDiscriminatorType value)
        {
            return value switch
            {
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.AudioFromVideo => "audio_from_video",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.AudioIsolation => "audio_isolation",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.Image => "image",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.ImageToImage => "image_to_image",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.ImageUpscale => "image_upscale",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.MotionControl => "motion_control",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.SpeechToSpeech => "speech_to_speech",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.TextToSound => "text_to_sound",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.TextToSpeech => "text_to_speech",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.Video => "video",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoToVideo => "video_to_video",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoUpscale => "video_upscale",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoWithAudio => "video_with_audio",
                GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VoiceClone => "voice_clone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_from_video" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.AudioFromVideo,
                "audio_isolation" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.AudioIsolation,
                "image" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.Image,
                "image_to_image" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.ImageToImage,
                "image_upscale" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.ImageUpscale,
                "motion_control" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.MotionControl,
                "speech_to_speech" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.SpeechToSpeech,
                "text_to_sound" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.TextToSound,
                "text_to_speech" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.TextToSpeech,
                "video" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.Video,
                "video_to_video" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoToVideo,
                "video_upscale" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoUpscale,
                "video_with_audio" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoWithAudio,
                "voice_clone" => GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VoiceClone,
                _ => null,
            };
        }
    }
}