//HintName: G.Models.AssistantSupportedModels.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantSupportedModels
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
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini20240718,
        /// <summary>
        /// 
        /// </summary>
        Gpt45Preview,
        /// <summary>
        /// 
        /// </summary>
        Gpt45Preview20250227,
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
    public static class AssistantSupportedModelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantSupportedModels value)
        {
            return value switch
            {
                AssistantSupportedModels.Gpt41 => "gpt-4.1",
                AssistantSupportedModels.Gpt41Mini => "gpt-4.1-mini",
                AssistantSupportedModels.Gpt41Nano => "gpt-4.1-nano",
                AssistantSupportedModels.Gpt4120250414 => "gpt-4.1-2025-04-14",
                AssistantSupportedModels.Gpt41Mini20250414 => "gpt-4.1-mini-2025-04-14",
                AssistantSupportedModels.Gpt41Nano20250414 => "gpt-4.1-nano-2025-04-14",
                AssistantSupportedModels.O3Mini => "o3-mini",
                AssistantSupportedModels.O3Mini20250131 => "o3-mini-2025-01-31",
                AssistantSupportedModels.O1 => "o1",
                AssistantSupportedModels.O120241217 => "o1-2024-12-17",
                AssistantSupportedModels.Gpt4o => "gpt-4o",
                AssistantSupportedModels.Gpt4o20241120 => "gpt-4o-2024-11-20",
                AssistantSupportedModels.Gpt4o20240806 => "gpt-4o-2024-08-06",
                AssistantSupportedModels.Gpt4o20240513 => "gpt-4o-2024-05-13",
                AssistantSupportedModels.Gpt4oMini => "gpt-4o-mini",
                AssistantSupportedModels.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                AssistantSupportedModels.Gpt45Preview => "gpt-4.5-preview",
                AssistantSupportedModels.Gpt45Preview20250227 => "gpt-4.5-preview-2025-02-27",
                AssistantSupportedModels.Gpt4Turbo => "gpt-4-turbo",
                AssistantSupportedModels.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                AssistantSupportedModels.Gpt40125Preview => "gpt-4-0125-preview",
                AssistantSupportedModels.Gpt4TurboPreview => "gpt-4-turbo-preview",
                AssistantSupportedModels.Gpt41106Preview => "gpt-4-1106-preview",
                AssistantSupportedModels.Gpt4VisionPreview => "gpt-4-vision-preview",
                AssistantSupportedModels.Gpt4 => "gpt-4",
                AssistantSupportedModels.Gpt40314 => "gpt-4-0314",
                AssistantSupportedModels.Gpt40613 => "gpt-4-0613",
                AssistantSupportedModels.Gpt432k => "gpt-4-32k",
                AssistantSupportedModels.Gpt432k0314 => "gpt-4-32k-0314",
                AssistantSupportedModels.Gpt432k0613 => "gpt-4-32k-0613",
                AssistantSupportedModels.Gpt35Turbo => "gpt-3.5-turbo",
                AssistantSupportedModels.Gpt35Turbo16k => "gpt-3.5-turbo-16k",
                AssistantSupportedModels.Gpt35Turbo0613 => "gpt-3.5-turbo-0613",
                AssistantSupportedModels.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                AssistantSupportedModels.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                AssistantSupportedModels.Gpt35Turbo16k0613 => "gpt-3.5-turbo-16k-0613",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantSupportedModels? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => AssistantSupportedModels.Gpt41,
                "gpt-4.1-mini" => AssistantSupportedModels.Gpt41Mini,
                "gpt-4.1-nano" => AssistantSupportedModels.Gpt41Nano,
                "gpt-4.1-2025-04-14" => AssistantSupportedModels.Gpt4120250414,
                "gpt-4.1-mini-2025-04-14" => AssistantSupportedModels.Gpt41Mini20250414,
                "gpt-4.1-nano-2025-04-14" => AssistantSupportedModels.Gpt41Nano20250414,
                "o3-mini" => AssistantSupportedModels.O3Mini,
                "o3-mini-2025-01-31" => AssistantSupportedModels.O3Mini20250131,
                "o1" => AssistantSupportedModels.O1,
                "o1-2024-12-17" => AssistantSupportedModels.O120241217,
                "gpt-4o" => AssistantSupportedModels.Gpt4o,
                "gpt-4o-2024-11-20" => AssistantSupportedModels.Gpt4o20241120,
                "gpt-4o-2024-08-06" => AssistantSupportedModels.Gpt4o20240806,
                "gpt-4o-2024-05-13" => AssistantSupportedModels.Gpt4o20240513,
                "gpt-4o-mini" => AssistantSupportedModels.Gpt4oMini,
                "gpt-4o-mini-2024-07-18" => AssistantSupportedModels.Gpt4oMini20240718,
                "gpt-4.5-preview" => AssistantSupportedModels.Gpt45Preview,
                "gpt-4.5-preview-2025-02-27" => AssistantSupportedModels.Gpt45Preview20250227,
                "gpt-4-turbo" => AssistantSupportedModels.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => AssistantSupportedModels.Gpt4Turbo20240409,
                "gpt-4-0125-preview" => AssistantSupportedModels.Gpt40125Preview,
                "gpt-4-turbo-preview" => AssistantSupportedModels.Gpt4TurboPreview,
                "gpt-4-1106-preview" => AssistantSupportedModels.Gpt41106Preview,
                "gpt-4-vision-preview" => AssistantSupportedModels.Gpt4VisionPreview,
                "gpt-4" => AssistantSupportedModels.Gpt4,
                "gpt-4-0314" => AssistantSupportedModels.Gpt40314,
                "gpt-4-0613" => AssistantSupportedModels.Gpt40613,
                "gpt-4-32k" => AssistantSupportedModels.Gpt432k,
                "gpt-4-32k-0314" => AssistantSupportedModels.Gpt432k0314,
                "gpt-4-32k-0613" => AssistantSupportedModels.Gpt432k0613,
                "gpt-3.5-turbo" => AssistantSupportedModels.Gpt35Turbo,
                "gpt-3.5-turbo-16k" => AssistantSupportedModels.Gpt35Turbo16k,
                "gpt-3.5-turbo-0613" => AssistantSupportedModels.Gpt35Turbo0613,
                "gpt-3.5-turbo-1106" => AssistantSupportedModels.Gpt35Turbo1106,
                "gpt-3.5-turbo-0125" => AssistantSupportedModels.Gpt35Turbo0125,
                "gpt-3.5-turbo-16k-0613" => AssistantSupportedModels.Gpt35Turbo16k0613,
                _ => null,
            };
        }
    }
}