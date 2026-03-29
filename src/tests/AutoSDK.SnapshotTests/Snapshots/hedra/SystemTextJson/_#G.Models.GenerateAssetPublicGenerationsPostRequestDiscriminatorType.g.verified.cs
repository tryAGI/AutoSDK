//HintName: G.Models.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateAssetPublicGenerationsPostRequestDiscriminatorType
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