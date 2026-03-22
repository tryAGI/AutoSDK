//HintName: G.Models.Llm.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Llm
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-sonnet")]
        Claude35Sonnet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-sonnet-v1")]
        Claude35SonnetV1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-sonnet-v2@20241022")]
        Claude35SonnetV2_20241022,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-5-sonnet@20240620")]
        Claude35Sonnet_20240620,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-7-sonnet")]
        Claude37Sonnet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-7-sonnet@20250219")]
        Claude37Sonnet_20250219,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-haiku")]
        Claude3Haiku,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-3-haiku@20240307")]
        Claude3Haiku_20240307,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-haiku-4-5")]
        ClaudeHaiku45,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-haiku-4-5@20251001")]
        ClaudeHaiku45_20251001,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-sonnet-4")]
        ClaudeSonnet4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-sonnet-4-5")]
        ClaudeSonnet45,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-sonnet-4-5@20250929")]
        ClaudeSonnet45_20250929,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-sonnet-4-6")]
        ClaudeSonnet46,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="claude-sonnet-4@20250514")]
        ClaudeSonnet4_20250514,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom-llm")]
        CustomLlm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-1.5-flash")]
        Gemini15Flash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-1.5-flash-001")]
        Gemini15Flash001,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-1.5-flash-002")]
        Gemini15Flash002,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-1.5-pro")]
        Gemini15Pro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-1.5-pro-001")]
        Gemini15Pro001,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-1.5-pro-002")]
        Gemini15Pro002,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.0-flash")]
        Gemini20Flash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.0-flash-001")]
        Gemini20Flash001,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.0-flash-lite")]
        Gemini20FlashLite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.0-flash-lite-001")]
        Gemini20FlashLite001,
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
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.5-flash-lite-preview-06-17")]
        Gemini25FlashLitePreview0617,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.5-flash-lite-preview-09-2025")]
        Gemini25FlashLitePreview092025,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.5-flash-preview-04-17")]
        Gemini25FlashPreview0417,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.5-flash-preview-05-20")]
        Gemini25FlashPreview0520,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.5-flash-preview-09-2025")]
        Gemini25FlashPreview092025,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-3-flash-preview")]
        Gemini3FlashPreview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-3-pro-preview")]
        Gemini3ProPreview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-3.1-flash-lite-preview")]
        Gemini31FlashLitePreview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="glm-45-air-fp8")]
        Glm45AirFp8,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo")]
        Gpt35Turbo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-0125")]
        Gpt35Turbo0125,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-1106")]
        Gpt35Turbo1106,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4")]
        Gpt4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-0314")]
        Gpt40314,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-0613")]
        Gpt40613,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-turbo")]
        Gpt4Turbo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-turbo-2024-04-09")]
        Gpt4Turbo20240409,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1")]
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-2025-04-14")]
        Gpt4120250414,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini")]
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini-2025-04-14")]
        Gpt41Mini20250414,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-nano")]
        Gpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-nano-2025-04-14")]
        Gpt41Nano20250414,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o")]
        Gpt4o,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-05-13")]
        Gpt4o20240513,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-08-06")]
        Gpt4o20240806,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-11-20")]
        Gpt4o20241120,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini")]
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-2024-07-18")]
        Gpt4oMini20240718,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5")]
        Gpt5,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5-2025-08-07")]
        Gpt520250807,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5-mini")]
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5-mini-2025-08-07")]
        Gpt5Mini20250807,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5-nano")]
        Gpt5Nano,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5-nano-2025-08-07")]
        Gpt5Nano20250807,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5.1")]
        Gpt51,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5.1-2025-11-13")]
        Gpt5120251113,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5.2")]
        Gpt52,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5.2-2025-12-11")]
        Gpt5220251211,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5.2-chat-latest")]
        Gpt52ChatLatest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-oss-120b")]
        GptOss120b,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-oss-20b")]
        GptOss20b,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="grok-beta")]
        GrokBeta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="qwen3-30b-a3b")]
        Qwen330bA3b,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="qwen3-4b")]
        Qwen34b,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="watt-tool-70b")]
        WattTool70b,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="watt-tool-8b")]
        WattTool8b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Llm value)
        {
            return value switch
            {
                Llm.Claude35Sonnet => "claude-3-5-sonnet",
                Llm.Claude35SonnetV1 => "claude-3-5-sonnet-v1",
                Llm.Claude35SonnetV2_20241022 => "claude-3-5-sonnet-v2@20241022",
                Llm.Claude35Sonnet_20240620 => "claude-3-5-sonnet@20240620",
                Llm.Claude37Sonnet => "claude-3-7-sonnet",
                Llm.Claude37Sonnet_20250219 => "claude-3-7-sonnet@20250219",
                Llm.Claude3Haiku => "claude-3-haiku",
                Llm.Claude3Haiku_20240307 => "claude-3-haiku@20240307",
                Llm.ClaudeHaiku45 => "claude-haiku-4-5",
                Llm.ClaudeHaiku45_20251001 => "claude-haiku-4-5@20251001",
                Llm.ClaudeSonnet4 => "claude-sonnet-4",
                Llm.ClaudeSonnet45 => "claude-sonnet-4-5",
                Llm.ClaudeSonnet45_20250929 => "claude-sonnet-4-5@20250929",
                Llm.ClaudeSonnet46 => "claude-sonnet-4-6",
                Llm.ClaudeSonnet4_20250514 => "claude-sonnet-4@20250514",
                Llm.CustomLlm => "custom-llm",
                Llm.Gemini15Flash => "gemini-1.5-flash",
                Llm.Gemini15Flash001 => "gemini-1.5-flash-001",
                Llm.Gemini15Flash002 => "gemini-1.5-flash-002",
                Llm.Gemini15Pro => "gemini-1.5-pro",
                Llm.Gemini15Pro001 => "gemini-1.5-pro-001",
                Llm.Gemini15Pro002 => "gemini-1.5-pro-002",
                Llm.Gemini20Flash => "gemini-2.0-flash",
                Llm.Gemini20Flash001 => "gemini-2.0-flash-001",
                Llm.Gemini20FlashLite => "gemini-2.0-flash-lite",
                Llm.Gemini20FlashLite001 => "gemini-2.0-flash-lite-001",
                Llm.Gemini25Flash => "gemini-2.5-flash",
                Llm.Gemini25FlashLite => "gemini-2.5-flash-lite",
                Llm.Gemini25FlashLitePreview0617 => "gemini-2.5-flash-lite-preview-06-17",
                Llm.Gemini25FlashLitePreview092025 => "gemini-2.5-flash-lite-preview-09-2025",
                Llm.Gemini25FlashPreview0417 => "gemini-2.5-flash-preview-04-17",
                Llm.Gemini25FlashPreview0520 => "gemini-2.5-flash-preview-05-20",
                Llm.Gemini25FlashPreview092025 => "gemini-2.5-flash-preview-09-2025",
                Llm.Gemini3FlashPreview => "gemini-3-flash-preview",
                Llm.Gemini3ProPreview => "gemini-3-pro-preview",
                Llm.Gemini31FlashLitePreview => "gemini-3.1-flash-lite-preview",
                Llm.Glm45AirFp8 => "glm-45-air-fp8",
                Llm.Gpt35Turbo => "gpt-3.5-turbo",
                Llm.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                Llm.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                Llm.Gpt4 => "gpt-4",
                Llm.Gpt40314 => "gpt-4-0314",
                Llm.Gpt40613 => "gpt-4-0613",
                Llm.Gpt4Turbo => "gpt-4-turbo",
                Llm.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                Llm.Gpt41 => "gpt-4.1",
                Llm.Gpt4120250414 => "gpt-4.1-2025-04-14",
                Llm.Gpt41Mini => "gpt-4.1-mini",
                Llm.Gpt41Mini20250414 => "gpt-4.1-mini-2025-04-14",
                Llm.Gpt41Nano => "gpt-4.1-nano",
                Llm.Gpt41Nano20250414 => "gpt-4.1-nano-2025-04-14",
                Llm.Gpt4o => "gpt-4o",
                Llm.Gpt4o20240513 => "gpt-4o-2024-05-13",
                Llm.Gpt4o20240806 => "gpt-4o-2024-08-06",
                Llm.Gpt4o20241120 => "gpt-4o-2024-11-20",
                Llm.Gpt4oMini => "gpt-4o-mini",
                Llm.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                Llm.Gpt5 => "gpt-5",
                Llm.Gpt520250807 => "gpt-5-2025-08-07",
                Llm.Gpt5Mini => "gpt-5-mini",
                Llm.Gpt5Mini20250807 => "gpt-5-mini-2025-08-07",
                Llm.Gpt5Nano => "gpt-5-nano",
                Llm.Gpt5Nano20250807 => "gpt-5-nano-2025-08-07",
                Llm.Gpt51 => "gpt-5.1",
                Llm.Gpt5120251113 => "gpt-5.1-2025-11-13",
                Llm.Gpt52 => "gpt-5.2",
                Llm.Gpt5220251211 => "gpt-5.2-2025-12-11",
                Llm.Gpt52ChatLatest => "gpt-5.2-chat-latest",
                Llm.GptOss120b => "gpt-oss-120b",
                Llm.GptOss20b => "gpt-oss-20b",
                Llm.GrokBeta => "grok-beta",
                Llm.Qwen330bA3b => "qwen3-30b-a3b",
                Llm.Qwen34b => "qwen3-4b",
                Llm.WattTool70b => "watt-tool-70b",
                Llm.WattTool8b => "watt-tool-8b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Llm? ToEnum(string value)
        {
            return value switch
            {
                "claude-3-5-sonnet" => Llm.Claude35Sonnet,
                "claude-3-5-sonnet-v1" => Llm.Claude35SonnetV1,
                "claude-3-5-sonnet-v2@20241022" => Llm.Claude35SonnetV2_20241022,
                "claude-3-5-sonnet@20240620" => Llm.Claude35Sonnet_20240620,
                "claude-3-7-sonnet" => Llm.Claude37Sonnet,
                "claude-3-7-sonnet@20250219" => Llm.Claude37Sonnet_20250219,
                "claude-3-haiku" => Llm.Claude3Haiku,
                "claude-3-haiku@20240307" => Llm.Claude3Haiku_20240307,
                "claude-haiku-4-5" => Llm.ClaudeHaiku45,
                "claude-haiku-4-5@20251001" => Llm.ClaudeHaiku45_20251001,
                "claude-sonnet-4" => Llm.ClaudeSonnet4,
                "claude-sonnet-4-5" => Llm.ClaudeSonnet45,
                "claude-sonnet-4-5@20250929" => Llm.ClaudeSonnet45_20250929,
                "claude-sonnet-4-6" => Llm.ClaudeSonnet46,
                "claude-sonnet-4@20250514" => Llm.ClaudeSonnet4_20250514,
                "custom-llm" => Llm.CustomLlm,
                "gemini-1.5-flash" => Llm.Gemini15Flash,
                "gemini-1.5-flash-001" => Llm.Gemini15Flash001,
                "gemini-1.5-flash-002" => Llm.Gemini15Flash002,
                "gemini-1.5-pro" => Llm.Gemini15Pro,
                "gemini-1.5-pro-001" => Llm.Gemini15Pro001,
                "gemini-1.5-pro-002" => Llm.Gemini15Pro002,
                "gemini-2.0-flash" => Llm.Gemini20Flash,
                "gemini-2.0-flash-001" => Llm.Gemini20Flash001,
                "gemini-2.0-flash-lite" => Llm.Gemini20FlashLite,
                "gemini-2.0-flash-lite-001" => Llm.Gemini20FlashLite001,
                "gemini-2.5-flash" => Llm.Gemini25Flash,
                "gemini-2.5-flash-lite" => Llm.Gemini25FlashLite,
                "gemini-2.5-flash-lite-preview-06-17" => Llm.Gemini25FlashLitePreview0617,
                "gemini-2.5-flash-lite-preview-09-2025" => Llm.Gemini25FlashLitePreview092025,
                "gemini-2.5-flash-preview-04-17" => Llm.Gemini25FlashPreview0417,
                "gemini-2.5-flash-preview-05-20" => Llm.Gemini25FlashPreview0520,
                "gemini-2.5-flash-preview-09-2025" => Llm.Gemini25FlashPreview092025,
                "gemini-3-flash-preview" => Llm.Gemini3FlashPreview,
                "gemini-3-pro-preview" => Llm.Gemini3ProPreview,
                "gemini-3.1-flash-lite-preview" => Llm.Gemini31FlashLitePreview,
                "glm-45-air-fp8" => Llm.Glm45AirFp8,
                "gpt-3.5-turbo" => Llm.Gpt35Turbo,
                "gpt-3.5-turbo-0125" => Llm.Gpt35Turbo0125,
                "gpt-3.5-turbo-1106" => Llm.Gpt35Turbo1106,
                "gpt-4" => Llm.Gpt4,
                "gpt-4-0314" => Llm.Gpt40314,
                "gpt-4-0613" => Llm.Gpt40613,
                "gpt-4-turbo" => Llm.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => Llm.Gpt4Turbo20240409,
                "gpt-4.1" => Llm.Gpt41,
                "gpt-4.1-2025-04-14" => Llm.Gpt4120250414,
                "gpt-4.1-mini" => Llm.Gpt41Mini,
                "gpt-4.1-mini-2025-04-14" => Llm.Gpt41Mini20250414,
                "gpt-4.1-nano" => Llm.Gpt41Nano,
                "gpt-4.1-nano-2025-04-14" => Llm.Gpt41Nano20250414,
                "gpt-4o" => Llm.Gpt4o,
                "gpt-4o-2024-05-13" => Llm.Gpt4o20240513,
                "gpt-4o-2024-08-06" => Llm.Gpt4o20240806,
                "gpt-4o-2024-11-20" => Llm.Gpt4o20241120,
                "gpt-4o-mini" => Llm.Gpt4oMini,
                "gpt-4o-mini-2024-07-18" => Llm.Gpt4oMini20240718,
                "gpt-5" => Llm.Gpt5,
                "gpt-5-2025-08-07" => Llm.Gpt520250807,
                "gpt-5-mini" => Llm.Gpt5Mini,
                "gpt-5-mini-2025-08-07" => Llm.Gpt5Mini20250807,
                "gpt-5-nano" => Llm.Gpt5Nano,
                "gpt-5-nano-2025-08-07" => Llm.Gpt5Nano20250807,
                "gpt-5.1" => Llm.Gpt51,
                "gpt-5.1-2025-11-13" => Llm.Gpt5120251113,
                "gpt-5.2" => Llm.Gpt52,
                "gpt-5.2-2025-12-11" => Llm.Gpt5220251211,
                "gpt-5.2-chat-latest" => Llm.Gpt52ChatLatest,
                "gpt-oss-120b" => Llm.GptOss120b,
                "gpt-oss-20b" => Llm.GptOss20b,
                "grok-beta" => Llm.GrokBeta,
                "qwen3-30b-a3b" => Llm.Qwen330bA3b,
                "qwen3-4b" => Llm.Qwen34b,
                "watt-tool-70b" => Llm.WattTool70b,
                "watt-tool-8b" => Llm.WattTool8b,
                _ => null,
            };
        }
    }
}