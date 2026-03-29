//HintName: G.Models.PublicModelName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Public model names.
    /// </summary>
    public enum PublicModelName
    {
        /// <summary>
        /// 
        /// </summary>
        AnthropicHaiku35,
        /// <summary>
        /// 
        /// </summary>
        AnthropicHaiku45,
        /// <summary>
        /// 
        /// </summary>
        AnthropicSonnet35,
        /// <summary>
        /// 
        /// </summary>
        AnthropicSonnet35V2,
        /// <summary>
        /// 
        /// </summary>
        AnthropicSonnet37,
        /// <summary>
        /// 
        /// </summary>
        AnthropicSonnet40,
        /// <summary>
        /// 
        /// </summary>
        AnthropicSonnet45,
        /// <summary>
        /// 
        /// </summary>
        Gemini15Flash,
        /// <summary>
        /// 
        /// </summary>
        Gemini15Pro,
        /// <summary>
        /// 
        /// </summary>
        Gemini20Flash,
        /// <summary>
        /// 
        /// </summary>
        Gemini20FlashLite,
        /// <summary>
        /// 
        /// </summary>
        Gemini25Flash,
        /// <summary>
        /// 
        /// </summary>
        Gemini25FlashLite,
        /// <summary>
        /// 
        /// </summary>
        Gemini25Pro,
        /// <summary>
        /// 
        /// </summary>
        Gemini30Pro,
        /// <summary>
        /// 
        /// </summary>
        Gemini31Pro,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGpt41,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGpt4o,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGpt5,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGpt5Nano,
        /// <summary>
        /// 
        /// </summary>
        OpenaiTextEmbedding3Large,
        /// <summary>
        /// 
        /// </summary>
        OpenaiTextEmbedding3Small,
        /// <summary>
        /// 
        /// </summary>
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