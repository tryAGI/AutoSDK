//HintName: G.Models.PublicModelName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Public model names.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PublicModelName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic-haiku-3.5")]
        AnthropicHaiku35,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic-haiku-4.5")]
        AnthropicHaiku45,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic-sonnet-3.5")]
        AnthropicSonnet35,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic-sonnet-3.5-v2")]
        AnthropicSonnet35V2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic-sonnet-3.7")]
        AnthropicSonnet37,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic-sonnet-4.0")]
        AnthropicSonnet40,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic-sonnet-4.5")]
        AnthropicSonnet45,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-1.5-flash")]
        Gemini15Flash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-1.5-pro")]
        Gemini15Pro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.0-flash")]
        Gemini20Flash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.0-flash-lite")]
        Gemini20FlashLite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.5-flash")]
        Gemini25Flash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.5-flash-lite")]
        Gemini25FlashLite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.5-pro")]
        Gemini25Pro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-3.0-pro")]
        Gemini30Pro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-3.1-pro")]
        Gemini31Pro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-4-1")]
        OpenaiGpt41,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-4-1-mini")]
        OpenaiGpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-4-1-nano")]
        OpenaiGpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-4o")]
        OpenaiGpt4o,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-4o-mini")]
        OpenaiGpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-5")]
        OpenaiGpt5,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-5-mini")]
        OpenaiGpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-5-nano")]
        OpenaiGpt5Nano,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-text-embedding-3-large")]
        OpenaiTextEmbedding3Large,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-text-embedding-3-small")]
        OpenaiTextEmbedding3Small,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-whisper-1")]
        OpenaiWhisper1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicModelName value)
        {
            return value switch
            {
                PublicModelName.AnthropicHaiku35 => "anthropic-haiku-3.5",
                PublicModelName.AnthropicHaiku45 => "anthropic-haiku-4.5",
                PublicModelName.AnthropicSonnet35 => "anthropic-sonnet-3.5",
                PublicModelName.AnthropicSonnet35V2 => "anthropic-sonnet-3.5-v2",
                PublicModelName.AnthropicSonnet37 => "anthropic-sonnet-3.7",
                PublicModelName.AnthropicSonnet40 => "anthropic-sonnet-4.0",
                PublicModelName.AnthropicSonnet45 => "anthropic-sonnet-4.5",
                PublicModelName.Gemini15Flash => "gemini-1.5-flash",
                PublicModelName.Gemini15Pro => "gemini-1.5-pro",
                PublicModelName.Gemini20Flash => "gemini-2.0-flash",
                PublicModelName.Gemini20FlashLite => "gemini-2.0-flash-lite",
                PublicModelName.Gemini25Flash => "gemini-2.5-flash",
                PublicModelName.Gemini25FlashLite => "gemini-2.5-flash-lite",
                PublicModelName.Gemini25Pro => "gemini-2.5-pro",
                PublicModelName.Gemini30Pro => "gemini-3.0-pro",
                PublicModelName.Gemini31Pro => "gemini-3.1-pro",
                PublicModelName.OpenaiGpt41 => "openai-gpt-4-1",
                PublicModelName.OpenaiGpt41Mini => "openai-gpt-4-1-mini",
                PublicModelName.OpenaiGpt41Nano => "openai-gpt-4-1-nano",
                PublicModelName.OpenaiGpt4o => "openai-gpt-4o",
                PublicModelName.OpenaiGpt4oMini => "openai-gpt-4o-mini",
                PublicModelName.OpenaiGpt5 => "openai-gpt-5",
                PublicModelName.OpenaiGpt5Mini => "openai-gpt-5-mini",
                PublicModelName.OpenaiGpt5Nano => "openai-gpt-5-nano",
                PublicModelName.OpenaiTextEmbedding3Large => "openai-text-embedding-3-large",
                PublicModelName.OpenaiTextEmbedding3Small => "openai-text-embedding-3-small",
                PublicModelName.OpenaiWhisper1 => "openai-whisper-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicModelName? ToEnum(string value)
        {
            return value switch
            {
                "anthropic-haiku-3.5" => PublicModelName.AnthropicHaiku35,
                "anthropic-haiku-4.5" => PublicModelName.AnthropicHaiku45,
                "anthropic-sonnet-3.5" => PublicModelName.AnthropicSonnet35,
                "anthropic-sonnet-3.5-v2" => PublicModelName.AnthropicSonnet35V2,
                "anthropic-sonnet-3.7" => PublicModelName.AnthropicSonnet37,
                "anthropic-sonnet-4.0" => PublicModelName.AnthropicSonnet40,
                "anthropic-sonnet-4.5" => PublicModelName.AnthropicSonnet45,
                "gemini-1.5-flash" => PublicModelName.Gemini15Flash,
                "gemini-1.5-pro" => PublicModelName.Gemini15Pro,
                "gemini-2.0-flash" => PublicModelName.Gemini20Flash,
                "gemini-2.0-flash-lite" => PublicModelName.Gemini20FlashLite,
                "gemini-2.5-flash" => PublicModelName.Gemini25Flash,
                "gemini-2.5-flash-lite" => PublicModelName.Gemini25FlashLite,
                "gemini-2.5-pro" => PublicModelName.Gemini25Pro,
                "gemini-3.0-pro" => PublicModelName.Gemini30Pro,
                "gemini-3.1-pro" => PublicModelName.Gemini31Pro,
                "openai-gpt-4-1" => PublicModelName.OpenaiGpt41,
                "openai-gpt-4-1-mini" => PublicModelName.OpenaiGpt41Mini,
                "openai-gpt-4-1-nano" => PublicModelName.OpenaiGpt41Nano,
                "openai-gpt-4o" => PublicModelName.OpenaiGpt4o,
                "openai-gpt-4o-mini" => PublicModelName.OpenaiGpt4oMini,
                "openai-gpt-5" => PublicModelName.OpenaiGpt5,
                "openai-gpt-5-mini" => PublicModelName.OpenaiGpt5Mini,
                "openai-gpt-5-nano" => PublicModelName.OpenaiGpt5Nano,
                "openai-text-embedding-3-large" => PublicModelName.OpenaiTextEmbedding3Large,
                "openai-text-embedding-3-small" => PublicModelName.OpenaiTextEmbedding3Small,
                "openai-whisper-1" => PublicModelName.OpenaiWhisper1,
                _ => null,
            };
        }
    }
}