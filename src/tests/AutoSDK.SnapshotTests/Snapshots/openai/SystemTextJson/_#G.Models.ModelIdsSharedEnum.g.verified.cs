//HintName: G.Models.ModelIdsSharedEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelIdsSharedEnum
    {
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
        O4Mini,
        /// <summary>
        /// 
        /// </summary>
        O4Mini20250416,
        /// <summary>
        /// 
        /// </summary>
        O3,
        /// <summary>
        /// 
        /// </summary>
        O320250416,
        /// <summary>
        /// 
        /// </summary>
        O3Mini,
        /// <summary>
        /// 
        /// </summary>
        O3Mini20250131,
        /// <summary>
        /// 
        /// </summary>
        O1,
        /// <summary>
        /// 
        /// </summary>
        O120241217,
        /// <summary>
        /// 
        /// </summary>
        O1Preview,
        /// <summary>
        /// 
        /// </summary>
        O1Preview20240912,
        /// <summary>
        /// 
        /// </summary>
        O1Mini,
        /// <summary>
        /// 
        /// </summary>
        O1Mini20240912,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o,
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
        Gpt4oAudioPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oAudioPreview20241001,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oAudioPreview20241217,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oAudioPreview20250603,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniAudioPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniAudioPreview20241217,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oSearchPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniSearchPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oSearchPreview20250311,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniSearchPreview20250311,
        /// <summary>
        /// 
        /// </summary>
        Chatgpt4oLatest,
        /// <summary>
        /// 
        /// </summary>
        CodexMiniLatest,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini20240718,
        /// <summary>
        /// 
        /// </summary>
        Gpt4Turbo,
        /// <summary>
        /// 
        /// </summary>
        Gpt4Turbo20240409,
        /// <summary>
        /// 
        /// </summary>
        Gpt40125Preview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4TurboPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt41106Preview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4VisionPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4,
        /// <summary>
        /// 
        /// </summary>
        Gpt40314,
        /// <summary>
        /// 
        /// </summary>
        Gpt40613,
        /// <summary>
        /// 
        /// </summary>
        Gpt432k,
        /// <summary>
        /// 
        /// </summary>
        Gpt432k0314,
        /// <summary>
        /// 
        /// </summary>
        Gpt432k0613,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo16k,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo0301,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo0613,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo1106,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo0125,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo16k0613,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelIdsSharedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelIdsSharedEnum value)
        {
            return value switch
            {
                ModelIdsSharedEnum.Gpt41 => "gpt-4.1",
                ModelIdsSharedEnum.Gpt41Mini => "gpt-4.1-mini",
                ModelIdsSharedEnum.Gpt41Nano => "gpt-4.1-nano",
                ModelIdsSharedEnum.Gpt4120250414 => "gpt-4.1-2025-04-14",
                ModelIdsSharedEnum.Gpt41Mini20250414 => "gpt-4.1-mini-2025-04-14",
                ModelIdsSharedEnum.Gpt41Nano20250414 => "gpt-4.1-nano-2025-04-14",
                ModelIdsSharedEnum.O4Mini => "o4-mini",
                ModelIdsSharedEnum.O4Mini20250416 => "o4-mini-2025-04-16",
                ModelIdsSharedEnum.O3 => "o3",
                ModelIdsSharedEnum.O320250416 => "o3-2025-04-16",
                ModelIdsSharedEnum.O3Mini => "o3-mini",
                ModelIdsSharedEnum.O3Mini20250131 => "o3-mini-2025-01-31",
                ModelIdsSharedEnum.O1 => "o1",
                ModelIdsSharedEnum.O120241217 => "o1-2024-12-17",
                ModelIdsSharedEnum.O1Preview => "o1-preview",
                ModelIdsSharedEnum.O1Preview20240912 => "o1-preview-2024-09-12",
                ModelIdsSharedEnum.O1Mini => "o1-mini",
                ModelIdsSharedEnum.O1Mini20240912 => "o1-mini-2024-09-12",
                ModelIdsSharedEnum.Gpt4o => "gpt-4o",
                ModelIdsSharedEnum.Gpt4o20241120 => "gpt-4o-2024-11-20",
                ModelIdsSharedEnum.Gpt4o20240806 => "gpt-4o-2024-08-06",
                ModelIdsSharedEnum.Gpt4o20240513 => "gpt-4o-2024-05-13",
                ModelIdsSharedEnum.Gpt4oAudioPreview => "gpt-4o-audio-preview",
                ModelIdsSharedEnum.Gpt4oAudioPreview20241001 => "gpt-4o-audio-preview-2024-10-01",
                ModelIdsSharedEnum.Gpt4oAudioPreview20241217 => "gpt-4o-audio-preview-2024-12-17",
                ModelIdsSharedEnum.Gpt4oAudioPreview20250603 => "gpt-4o-audio-preview-2025-06-03",
                ModelIdsSharedEnum.Gpt4oMiniAudioPreview => "gpt-4o-mini-audio-preview",
                ModelIdsSharedEnum.Gpt4oMiniAudioPreview20241217 => "gpt-4o-mini-audio-preview-2024-12-17",
                ModelIdsSharedEnum.Gpt4oSearchPreview => "gpt-4o-search-preview",
                ModelIdsSharedEnum.Gpt4oMiniSearchPreview => "gpt-4o-mini-search-preview",
                ModelIdsSharedEnum.Gpt4oSearchPreview20250311 => "gpt-4o-search-preview-2025-03-11",
                ModelIdsSharedEnum.Gpt4oMiniSearchPreview20250311 => "gpt-4o-mini-search-preview-2025-03-11",
                ModelIdsSharedEnum.Chatgpt4oLatest => "chatgpt-4o-latest",
                ModelIdsSharedEnum.CodexMiniLatest => "codex-mini-latest",
                ModelIdsSharedEnum.Gpt4oMini => "gpt-4o-mini",
                ModelIdsSharedEnum.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                ModelIdsSharedEnum.Gpt4Turbo => "gpt-4-turbo",
                ModelIdsSharedEnum.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                ModelIdsSharedEnum.Gpt40125Preview => "gpt-4-0125-preview",
                ModelIdsSharedEnum.Gpt4TurboPreview => "gpt-4-turbo-preview",
                ModelIdsSharedEnum.Gpt41106Preview => "gpt-4-1106-preview",
                ModelIdsSharedEnum.Gpt4VisionPreview => "gpt-4-vision-preview",
                ModelIdsSharedEnum.Gpt4 => "gpt-4",
                ModelIdsSharedEnum.Gpt40314 => "gpt-4-0314",
                ModelIdsSharedEnum.Gpt40613 => "gpt-4-0613",
                ModelIdsSharedEnum.Gpt432k => "gpt-4-32k",
                ModelIdsSharedEnum.Gpt432k0314 => "gpt-4-32k-0314",
                ModelIdsSharedEnum.Gpt432k0613 => "gpt-4-32k-0613",
                ModelIdsSharedEnum.Gpt35Turbo => "gpt-3.5-turbo",
                ModelIdsSharedEnum.Gpt35Turbo16k => "gpt-3.5-turbo-16k",
                ModelIdsSharedEnum.Gpt35Turbo0301 => "gpt-3.5-turbo-0301",
                ModelIdsSharedEnum.Gpt35Turbo0613 => "gpt-3.5-turbo-0613",
                ModelIdsSharedEnum.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                ModelIdsSharedEnum.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                ModelIdsSharedEnum.Gpt35Turbo16k0613 => "gpt-3.5-turbo-16k-0613",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelIdsSharedEnum? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => ModelIdsSharedEnum.Gpt41,
                "gpt-4.1-mini" => ModelIdsSharedEnum.Gpt41Mini,
                "gpt-4.1-nano" => ModelIdsSharedEnum.Gpt41Nano,
                "gpt-4.1-2025-04-14" => ModelIdsSharedEnum.Gpt4120250414,
                "gpt-4.1-mini-2025-04-14" => ModelIdsSharedEnum.Gpt41Mini20250414,
                "gpt-4.1-nano-2025-04-14" => ModelIdsSharedEnum.Gpt41Nano20250414,
                "o4-mini" => ModelIdsSharedEnum.O4Mini,
                "o4-mini-2025-04-16" => ModelIdsSharedEnum.O4Mini20250416,
                "o3" => ModelIdsSharedEnum.O3,
                "o3-2025-04-16" => ModelIdsSharedEnum.O320250416,
                "o3-mini" => ModelIdsSharedEnum.O3Mini,
                "o3-mini-2025-01-31" => ModelIdsSharedEnum.O3Mini20250131,
                "o1" => ModelIdsSharedEnum.O1,
                "o1-2024-12-17" => ModelIdsSharedEnum.O120241217,
                "o1-preview" => ModelIdsSharedEnum.O1Preview,
                "o1-preview-2024-09-12" => ModelIdsSharedEnum.O1Preview20240912,
                "o1-mini" => ModelIdsSharedEnum.O1Mini,
                "o1-mini-2024-09-12" => ModelIdsSharedEnum.O1Mini20240912,
                "gpt-4o" => ModelIdsSharedEnum.Gpt4o,
                "gpt-4o-2024-11-20" => ModelIdsSharedEnum.Gpt4o20241120,
                "gpt-4o-2024-08-06" => ModelIdsSharedEnum.Gpt4o20240806,
                "gpt-4o-2024-05-13" => ModelIdsSharedEnum.Gpt4o20240513,
                "gpt-4o-audio-preview" => ModelIdsSharedEnum.Gpt4oAudioPreview,
                "gpt-4o-audio-preview-2024-10-01" => ModelIdsSharedEnum.Gpt4oAudioPreview20241001,
                "gpt-4o-audio-preview-2024-12-17" => ModelIdsSharedEnum.Gpt4oAudioPreview20241217,
                "gpt-4o-audio-preview-2025-06-03" => ModelIdsSharedEnum.Gpt4oAudioPreview20250603,
                "gpt-4o-mini-audio-preview" => ModelIdsSharedEnum.Gpt4oMiniAudioPreview,
                "gpt-4o-mini-audio-preview-2024-12-17" => ModelIdsSharedEnum.Gpt4oMiniAudioPreview20241217,
                "gpt-4o-search-preview" => ModelIdsSharedEnum.Gpt4oSearchPreview,
                "gpt-4o-mini-search-preview" => ModelIdsSharedEnum.Gpt4oMiniSearchPreview,
                "gpt-4o-search-preview-2025-03-11" => ModelIdsSharedEnum.Gpt4oSearchPreview20250311,
                "gpt-4o-mini-search-preview-2025-03-11" => ModelIdsSharedEnum.Gpt4oMiniSearchPreview20250311,
                "chatgpt-4o-latest" => ModelIdsSharedEnum.Chatgpt4oLatest,
                "codex-mini-latest" => ModelIdsSharedEnum.CodexMiniLatest,
                "gpt-4o-mini" => ModelIdsSharedEnum.Gpt4oMini,
                "gpt-4o-mini-2024-07-18" => ModelIdsSharedEnum.Gpt4oMini20240718,
                "gpt-4-turbo" => ModelIdsSharedEnum.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => ModelIdsSharedEnum.Gpt4Turbo20240409,
                "gpt-4-0125-preview" => ModelIdsSharedEnum.Gpt40125Preview,
                "gpt-4-turbo-preview" => ModelIdsSharedEnum.Gpt4TurboPreview,
                "gpt-4-1106-preview" => ModelIdsSharedEnum.Gpt41106Preview,
                "gpt-4-vision-preview" => ModelIdsSharedEnum.Gpt4VisionPreview,
                "gpt-4" => ModelIdsSharedEnum.Gpt4,
                "gpt-4-0314" => ModelIdsSharedEnum.Gpt40314,
                "gpt-4-0613" => ModelIdsSharedEnum.Gpt40613,
                "gpt-4-32k" => ModelIdsSharedEnum.Gpt432k,
                "gpt-4-32k-0314" => ModelIdsSharedEnum.Gpt432k0314,
                "gpt-4-32k-0613" => ModelIdsSharedEnum.Gpt432k0613,
                "gpt-3.5-turbo" => ModelIdsSharedEnum.Gpt35Turbo,
                "gpt-3.5-turbo-16k" => ModelIdsSharedEnum.Gpt35Turbo16k,
                "gpt-3.5-turbo-0301" => ModelIdsSharedEnum.Gpt35Turbo0301,
                "gpt-3.5-turbo-0613" => ModelIdsSharedEnum.Gpt35Turbo0613,
                "gpt-3.5-turbo-1106" => ModelIdsSharedEnum.Gpt35Turbo1106,
                "gpt-3.5-turbo-0125" => ModelIdsSharedEnum.Gpt35Turbo0125,
                "gpt-3.5-turbo-16k-0613" => ModelIdsSharedEnum.Gpt35Turbo16k0613,
                _ => null,
            };
        }
    }
}