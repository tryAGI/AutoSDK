//HintName: G.Models.LLM.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLM
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o,
        /// <summary>
        /// 
        /// </summary>
        Gpt4,
        /// <summary>
        /// 
        /// </summary>
        Gpt4Turbo,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo,
        /// <summary>
        /// 
        /// </summary>
        Gemini15Pro,
        /// <summary>
        /// 
        /// </summary>
        Gemini15Flash,
        /// <summary>
        /// 
        /// </summary>
        Gemini20Flash001,
        /// <summary>
        /// 
        /// </summary>
        Gemini20FlashLite,
        /// <summary>
        /// 
        /// </summary>
        Gemini10Pro,
        /// <summary>
        /// 
        /// </summary>
        Claude37Sonnet,
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet,
        /// <summary>
        /// 
        /// </summary>
        Claude35SonnetV1,
        /// <summary>
        /// 
        /// </summary>
        Claude3Haiku,
        /// <summary>
        /// 
        /// </summary>
        GrokBeta,
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLM value)
        {
            return value switch
            {
                LLM.Gpt4oMini => "gpt-4o-mini",
                LLM.Gpt4o => "gpt-4o",
                LLM.Gpt4 => "gpt-4",
                LLM.Gpt4Turbo => "gpt-4-turbo",
                LLM.Gpt35Turbo => "gpt-3.5-turbo",
                LLM.Gemini15Pro => "gemini-1.5-pro",
                LLM.Gemini15Flash => "gemini-1.5-flash",
                LLM.Gemini20Flash001 => "gemini-2.0-flash-001",
                LLM.Gemini20FlashLite => "gemini-2.0-flash-lite",
                LLM.Gemini10Pro => "gemini-1.0-pro",
                LLM.Claude37Sonnet => "claude-3-7-sonnet",
                LLM.Claude35Sonnet => "claude-3-5-sonnet",
                LLM.Claude35SonnetV1 => "claude-3-5-sonnet-v1",
                LLM.Claude3Haiku => "claude-3-haiku",
                LLM.GrokBeta => "grok-beta",
                LLM.CustomLlm => "custom-llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLM? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o-mini" => LLM.Gpt4oMini,
                "gpt-4o" => LLM.Gpt4o,
                "gpt-4" => LLM.Gpt4,
                "gpt-4-turbo" => LLM.Gpt4Turbo,
                "gpt-3.5-turbo" => LLM.Gpt35Turbo,
                "gemini-1.5-pro" => LLM.Gemini15Pro,
                "gemini-1.5-flash" => LLM.Gemini15Flash,
                "gemini-2.0-flash-001" => LLM.Gemini20Flash001,
                "gemini-2.0-flash-lite" => LLM.Gemini20FlashLite,
                "gemini-1.0-pro" => LLM.Gemini10Pro,
                "claude-3-7-sonnet" => LLM.Claude37Sonnet,
                "claude-3-5-sonnet" => LLM.Claude35Sonnet,
                "claude-3-5-sonnet-v1" => LLM.Claude35SonnetV1,
                "claude-3-haiku" => LLM.Claude3Haiku,
                "grok-beta" => LLM.GrokBeta,
                "custom-llm" => LLM.CustomLlm,
                _ => null,
            };
        }
    }
}