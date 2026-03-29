//HintName: G.Models.GenerationInputDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GenerationInputDiscriminatorType
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
    public static class GenerationInputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationInputDiscriminatorType value)
        {
            return value switch
            {
                GenerationInputDiscriminatorType.AudioFromVideo => "audio_from_video",
                GenerationInputDiscriminatorType.AudioIsolation => "audio_isolation",
                GenerationInputDiscriminatorType.Image => "image",
                GenerationInputDiscriminatorType.ImageToImage => "image_to_image",
                GenerationInputDiscriminatorType.ImageUpscale => "image_upscale",
                GenerationInputDiscriminatorType.MotionControl => "motion_control",
                GenerationInputDiscriminatorType.SpeechToSpeech => "speech_to_speech",
                GenerationInputDiscriminatorType.TextToSound => "text_to_sound",
                GenerationInputDiscriminatorType.TextToSpeech => "text_to_speech",
                GenerationInputDiscriminatorType.Video => "video",
                GenerationInputDiscriminatorType.VideoToVideo => "video_to_video",
                GenerationInputDiscriminatorType.VideoUpscale => "video_upscale",
                GenerationInputDiscriminatorType.VideoWithAudio => "video_with_audio",
                GenerationInputDiscriminatorType.VoiceClone => "voice_clone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationInputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio_from_video" => GenerationInputDiscriminatorType.AudioFromVideo,
                "audio_isolation" => GenerationInputDiscriminatorType.AudioIsolation,
                "image" => GenerationInputDiscriminatorType.Image,
                "image_to_image" => GenerationInputDiscriminatorType.ImageToImage,
                "image_upscale" => GenerationInputDiscriminatorType.ImageUpscale,
                "motion_control" => GenerationInputDiscriminatorType.MotionControl,
                "speech_to_speech" => GenerationInputDiscriminatorType.SpeechToSpeech,
                "text_to_sound" => GenerationInputDiscriminatorType.TextToSound,
                "text_to_speech" => GenerationInputDiscriminatorType.TextToSpeech,
                "video" => GenerationInputDiscriminatorType.Video,
                "video_to_video" => GenerationInputDiscriminatorType.VideoToVideo,
                "video_upscale" => GenerationInputDiscriminatorType.VideoUpscale,
                "video_with_audio" => GenerationInputDiscriminatorType.VideoWithAudio,
                "voice_clone" => GenerationInputDiscriminatorType.VoiceClone,
                _ => null,
            };
        }
    }
}