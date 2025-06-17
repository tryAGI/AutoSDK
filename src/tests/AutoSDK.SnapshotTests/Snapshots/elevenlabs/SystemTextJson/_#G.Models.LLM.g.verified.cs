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
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano,
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
        ClaudeSonnet4,
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
        /// <summary>
        /// 
        /// </summary>
        Gemini25FlashPreview0520,
        /// <summary>
        /// 
        /// </summary>
        Gemini25FlashPreview0417,
        /// <summary>
        /// 
        /// </summary>
        Gemini20FlashLite001,
        /// <summary>
        /// 
        /// </summary>
        Gemini20Flash001,
        /// <summary>
        /// 
        /// </summary>
        Gemini15Flash002,
        /// <summary>
        /// 
        /// </summary>
        Gemini15Flash001,
        /// <summary>
        /// 
        /// </summary>
        Gemini15Pro002,
        /// <summary>
        /// 
        /// </summary>
        Gemini15Pro001,
        /// <summary>
        /// 
        /// </summary>
        ClaudeSonnet4_20250514,
        /// <summary>
        /// 
        /// </summary>
        Claude37Sonnet_20250219,
        /// <summary>
        /// 
        /// </summary>
        Claude35Sonnet_20240620,
        /// <summary>
        /// 
        /// </summary>
        Claude35SonnetV2_20241022,
        /// <summary>
        /// 
        /// </summary>
        Claude3Haiku_20240307,
        /// <summary>
        /// 
        /// </summary>
        Gpt4120250414,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini20250414,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano20250414,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini20240718,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20241120,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240806,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240513,
        /// <summary>
        /// 
        /// </summary>
        Gpt40613,
        /// <summary>
        /// 
        /// </summary>
        Gpt40314,
        /// <summary>
        /// 
        /// </summary>
        Gpt4Turbo20240409,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo0125,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo1106,
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
                LLM.Gpt41 => "gpt-4.1",
                LLM.Gpt41Mini => "gpt-4.1-mini",
                LLM.Gpt41Nano => "gpt-4.1-nano",
                LLM.Gpt35Turbo => "gpt-3.5-turbo",
                LLM.Gemini15Pro => "gemini-1.5-pro",
                LLM.Gemini15Flash => "gemini-1.5-flash",
                LLM.Gemini20Flash => "gemini-2.0-flash",
                LLM.Gemini20FlashLite => "gemini-2.0-flash-lite",
                LLM.Gemini25Flash => "gemini-2.5-flash",
                LLM.ClaudeSonnet4 => "claude-sonnet-4",
                LLM.Claude37Sonnet => "claude-3-7-sonnet",
                LLM.Claude35Sonnet => "claude-3-5-sonnet",
                LLM.Claude35SonnetV1 => "claude-3-5-sonnet-v1",
                LLM.Claude3Haiku => "claude-3-haiku",
                LLM.GrokBeta => "grok-beta",
                LLM.CustomLlm => "custom-llm",
                LLM.Gemini25FlashPreview0520 => "gemini-2.5-flash-preview-05-20",
                LLM.Gemini25FlashPreview0417 => "gemini-2.5-flash-preview-04-17",
                LLM.Gemini20FlashLite001 => "gemini-2.0-flash-lite-001",
                LLM.Gemini20Flash001 => "gemini-2.0-flash-001",
                LLM.Gemini15Flash002 => "gemini-1.5-flash-002",
                LLM.Gemini15Flash001 => "gemini-1.5-flash-001",
                LLM.Gemini15Pro002 => "gemini-1.5-pro-002",
                LLM.Gemini15Pro001 => "gemini-1.5-pro-001",
                LLM.ClaudeSonnet4_20250514 => "claude-sonnet-4@20250514",
                LLM.Claude37Sonnet_20250219 => "claude-3-7-sonnet@20250219",
                LLM.Claude35Sonnet_20240620 => "claude-3-5-sonnet@20240620",
                LLM.Claude35SonnetV2_20241022 => "claude-3-5-sonnet-v2@20241022",
                LLM.Claude3Haiku_20240307 => "claude-3-haiku@20240307",
                LLM.Gpt4120250414 => "gpt-4.1-2025-04-14",
                LLM.Gpt41Mini20250414 => "gpt-4.1-mini-2025-04-14",
                LLM.Gpt41Nano20250414 => "gpt-4.1-nano-2025-04-14",
                LLM.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                LLM.Gpt4o20241120 => "gpt-4o-2024-11-20",
                LLM.Gpt4o20240806 => "gpt-4o-2024-08-06",
                LLM.Gpt4o20240513 => "gpt-4o-2024-05-13",
                LLM.Gpt40613 => "gpt-4-0613",
                LLM.Gpt40314 => "gpt-4-0314",
                LLM.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                LLM.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                LLM.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
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
                "gpt-4.1" => LLM.Gpt41,
                "gpt-4.1-mini" => LLM.Gpt41Mini,
                "gpt-4.1-nano" => LLM.Gpt41Nano,
                "gpt-3.5-turbo" => LLM.Gpt35Turbo,
                "gemini-1.5-pro" => LLM.Gemini15Pro,
                "gemini-1.5-flash" => LLM.Gemini15Flash,
                "gemini-2.0-flash" => LLM.Gemini20Flash,
                "gemini-2.0-flash-lite" => LLM.Gemini20FlashLite,
                "gemini-2.5-flash" => LLM.Gemini25Flash,
                "claude-sonnet-4" => LLM.ClaudeSonnet4,
                "claude-3-7-sonnet" => LLM.Claude37Sonnet,
                "claude-3-5-sonnet" => LLM.Claude35Sonnet,
                "claude-3-5-sonnet-v1" => LLM.Claude35SonnetV1,
                "claude-3-haiku" => LLM.Claude3Haiku,
                "grok-beta" => LLM.GrokBeta,
                "custom-llm" => LLM.CustomLlm,
                "gemini-2.5-flash-preview-05-20" => LLM.Gemini25FlashPreview0520,
                "gemini-2.5-flash-preview-04-17" => LLM.Gemini25FlashPreview0417,
                "gemini-2.0-flash-lite-001" => LLM.Gemini20FlashLite001,
                "gemini-2.0-flash-001" => LLM.Gemini20Flash001,
                "gemini-1.5-flash-002" => LLM.Gemini15Flash002,
                "gemini-1.5-flash-001" => LLM.Gemini15Flash001,
                "gemini-1.5-pro-002" => LLM.Gemini15Pro002,
                "gemini-1.5-pro-001" => LLM.Gemini15Pro001,
                "claude-sonnet-4@20250514" => LLM.ClaudeSonnet4_20250514,
                "claude-3-7-sonnet@20250219" => LLM.Claude37Sonnet_20250219,
                "claude-3-5-sonnet@20240620" => LLM.Claude35Sonnet_20240620,
                "claude-3-5-sonnet-v2@20241022" => LLM.Claude35SonnetV2_20241022,
                "claude-3-haiku@20240307" => LLM.Claude3Haiku_20240307,
                "gpt-4.1-2025-04-14" => LLM.Gpt4120250414,
                "gpt-4.1-mini-2025-04-14" => LLM.Gpt41Mini20250414,
                "gpt-4.1-nano-2025-04-14" => LLM.Gpt41Nano20250414,
                "gpt-4o-mini-2024-07-18" => LLM.Gpt4oMini20240718,
                "gpt-4o-2024-11-20" => LLM.Gpt4o20241120,
                "gpt-4o-2024-08-06" => LLM.Gpt4o20240806,
                "gpt-4o-2024-05-13" => LLM.Gpt4o20240513,
                "gpt-4-0613" => LLM.Gpt40613,
                "gpt-4-0314" => LLM.Gpt40314,
                "gpt-4-turbo-2024-04-09" => LLM.Gpt4Turbo20240409,
                "gpt-3.5-turbo-0125" => LLM.Gpt35Turbo0125,
                "gpt-3.5-turbo-1106" => LLM.Gpt35Turbo1106,
                _ => null,
            };
        }
    }
}