//HintName: G.Models.GenerationInputDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerationInputDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioFromVideo,
        /// <summary>
        /// 
        /// </summary>
        AudioIsolation,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        ImageToImage,
        /// <summary>
        /// 
        /// </summary>
        ImageUpscale,
        /// <summary>
        /// 
        /// </summary>
        MotionControl,
        /// <summary>
        /// 
        /// </summary>
        SpeechToSpeech,
        /// <summary>
        /// 
        /// </summary>
        TextToSound,
        /// <summary>
        /// 
        /// </summary>
        TextToSpeech,
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        VideoToVideo,
        /// <summary>
        /// 
        /// </summary>
        VideoUpscale,
        /// <summary>
        /// 
        /// </summary>
        VideoWithAudio,
        /// <summary>
        /// 
        /// </summary>
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