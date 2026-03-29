//HintName: G.Models.GenerationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generation type enum<br/>
    /// NOTE: this enum is used to determine the type of generation and is used to determine<br/>
    /// the type of asset that will be generated.
    /// </summary>
    public enum GenerationType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentResponse,
        /// <summary>
        /// 
        /// </summary>
        AssetsToAudioTextPrompt,
        /// <summary>
        /// 
        /// </summary>
        AssetsToImageTextPrompt,
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
        ImageUpscale,
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
        VideoStitching,
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
        VoiceClone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationType value)
        {
            return value switch
            {
                GenerationType.AgentResponse => "agent_response",
                GenerationType.AssetsToAudioTextPrompt => "assets_to_audio_text_prompt",
                GenerationType.AssetsToImageTextPrompt => "assets_to_image_text_prompt",
                GenerationType.AudioFromVideo => "audio_from_video",
                GenerationType.AudioIsolation => "audio_isolation",
                GenerationType.Image => "image",
                GenerationType.ImageUpscale => "image_upscale",
                GenerationType.SpeechToSpeech => "speech_to_speech",
                GenerationType.TextToSound => "text_to_sound",
                GenerationType.TextToSpeech => "text_to_speech",
                GenerationType.Video => "video",
                GenerationType.VideoStitching => "video_stitching",
                GenerationType.VideoToVideo => "video_to_video",
                GenerationType.VideoUpscale => "video_upscale",
                GenerationType.VoiceClone => "voice_clone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationType? ToEnum(string value)
        {
            return value switch
            {
                "agent_response" => GenerationType.AgentResponse,
                "assets_to_audio_text_prompt" => GenerationType.AssetsToAudioTextPrompt,
                "assets_to_image_text_prompt" => GenerationType.AssetsToImageTextPrompt,
                "audio_from_video" => GenerationType.AudioFromVideo,
                "audio_isolation" => GenerationType.AudioIsolation,
                "image" => GenerationType.Image,
                "image_upscale" => GenerationType.ImageUpscale,
                "speech_to_speech" => GenerationType.SpeechToSpeech,
                "text_to_sound" => GenerationType.TextToSound,
                "text_to_speech" => GenerationType.TextToSpeech,
                "video" => GenerationType.Video,
                "video_stitching" => GenerationType.VideoStitching,
                "video_to_video" => GenerationType.VideoToVideo,
                "video_upscale" => GenerationType.VideoUpscale,
                "voice_clone" => GenerationType.VoiceClone,
                _ => null,
            };
        }
    }
}