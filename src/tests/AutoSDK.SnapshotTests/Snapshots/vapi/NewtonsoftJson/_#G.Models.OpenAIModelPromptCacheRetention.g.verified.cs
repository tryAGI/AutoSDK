//HintName: G.Models.OpenAIModelPromptCacheRetention.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This controls the prompt cache retention policy for models that support extended caching (GPT-4.1, GPT-5 series).<br/>
    /// - `in_memory`: Default behavior, cache retained in GPU memory only<br/>
    /// - `24h`: Extended caching, keeps cached prefixes active for up to 24 hours by offloading to GPU-local storage<br/>
    /// Only applies to models: gpt-5.2, gpt-5.1, gpt-5.1-codex, gpt-5.1-codex-mini, gpt-5.1-chat-latest, gpt-5, gpt-5-codex, gpt-4.1<br/>
    /// @default undefined (uses API default which is 'in_memory')
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIModelPromptCacheRetention
    {
        /// <summary>
        /// Extended caching, keeps cached prefixes active for up to 24 hours by offloading to GPU-local storage
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="24h")]
        x24h,
        /// <summary>
        /// Default behavior, cache retained in GPU memory only
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_memory")]
        InMemory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIModelPromptCacheRetentionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIModelPromptCacheRetention value)
        {
            return value switch
            {
                OpenAIModelPromptCacheRetention.x24h => "24h",
                OpenAIModelPromptCacheRetention.InMemory => "in_memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIModelPromptCacheRetention? ToEnum(string value)
        {
            return value switch
            {
                "24h" => OpenAIModelPromptCacheRetention.x24h,
                "in_memory" => OpenAIModelPromptCacheRetention.InMemory,
                _ => null,
            };
        }
    }
}