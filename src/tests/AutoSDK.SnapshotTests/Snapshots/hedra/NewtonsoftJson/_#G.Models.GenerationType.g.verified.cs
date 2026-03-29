//HintName: G.Models.GenerationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Generation type enum<br/>
    /// NOTE: this enum is used to determine the type of generation and is used to determine<br/>
    /// the type of asset that will be generated.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GenerationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_response")]
        AgentResponse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assets_to_audio_text_prompt")]
        AssetsToAudioTextPrompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assets_to_image_text_prompt")]
        AssetsToImageTextPrompt,
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
        [global::System.Runtime.Serialization.EnumMember(Value="image_upscale")]
        ImageUpscale,
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
        [global::System.Runtime.Serialization.EnumMember(Value="video_stitching")]
        VideoStitching,
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
        [global::System.Runtime.Serialization.EnumMember(Value="voice_clone")]
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