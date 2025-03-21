//HintName: G.Models.ModelResponsePropertiesModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelResponsePropertiesModel
    {
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
        ComputerUsePreview,
        /// <summary>
        /// 
        /// </summary>
        ComputerUsePreview20250204,
        /// <summary>
        /// 
        /// </summary>
        ComputerUsePreview20250311,
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
        Gpt4oMiniAudioPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniAudioPreview20241217,
        /// <summary>
        /// 
        /// </summary>
        Chatgpt4oLatest,
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
    public static class ModelResponsePropertiesModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelResponsePropertiesModel value)
        {
            return value switch
            {
                ModelResponsePropertiesModel.O3Mini => "o3-mini",
                ModelResponsePropertiesModel.O3Mini20250131 => "o3-mini-2025-01-31",
                ModelResponsePropertiesModel.O1 => "o1",
                ModelResponsePropertiesModel.O120241217 => "o1-2024-12-17",
                ModelResponsePropertiesModel.O1Preview => "o1-preview",
                ModelResponsePropertiesModel.O1Preview20240912 => "o1-preview-2024-09-12",
                ModelResponsePropertiesModel.O1Mini => "o1-mini",
                ModelResponsePropertiesModel.O1Mini20240912 => "o1-mini-2024-09-12",
                ModelResponsePropertiesModel.ComputerUsePreview => "computer-use-preview",
                ModelResponsePropertiesModel.ComputerUsePreview20250204 => "computer-use-preview-2025-02-04",
                ModelResponsePropertiesModel.ComputerUsePreview20250311 => "computer-use-preview-2025-03-11",
                ModelResponsePropertiesModel.Gpt45Preview => "gpt-4.5-preview",
                ModelResponsePropertiesModel.Gpt45Preview20250227 => "gpt-4.5-preview-2025-02-27",
                ModelResponsePropertiesModel.Gpt4o => "gpt-4o",
                ModelResponsePropertiesModel.Gpt4o20241120 => "gpt-4o-2024-11-20",
                ModelResponsePropertiesModel.Gpt4o20240806 => "gpt-4o-2024-08-06",
                ModelResponsePropertiesModel.Gpt4o20240513 => "gpt-4o-2024-05-13",
                ModelResponsePropertiesModel.Gpt4oAudioPreview => "gpt-4o-audio-preview",
                ModelResponsePropertiesModel.Gpt4oAudioPreview20241001 => "gpt-4o-audio-preview-2024-10-01",
                ModelResponsePropertiesModel.Gpt4oAudioPreview20241217 => "gpt-4o-audio-preview-2024-12-17",
                ModelResponsePropertiesModel.Gpt4oMiniAudioPreview => "gpt-4o-mini-audio-preview",
                ModelResponsePropertiesModel.Gpt4oMiniAudioPreview20241217 => "gpt-4o-mini-audio-preview-2024-12-17",
                ModelResponsePropertiesModel.Chatgpt4oLatest => "chatgpt-4o-latest",
                ModelResponsePropertiesModel.Gpt4oMini => "gpt-4o-mini",
                ModelResponsePropertiesModel.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                ModelResponsePropertiesModel.Gpt4Turbo => "gpt-4-turbo",
                ModelResponsePropertiesModel.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                ModelResponsePropertiesModel.Gpt40125Preview => "gpt-4-0125-preview",
                ModelResponsePropertiesModel.Gpt4TurboPreview => "gpt-4-turbo-preview",
                ModelResponsePropertiesModel.Gpt41106Preview => "gpt-4-1106-preview",
                ModelResponsePropertiesModel.Gpt4VisionPreview => "gpt-4-vision-preview",
                ModelResponsePropertiesModel.Gpt4 => "gpt-4",
                ModelResponsePropertiesModel.Gpt40314 => "gpt-4-0314",
                ModelResponsePropertiesModel.Gpt40613 => "gpt-4-0613",
                ModelResponsePropertiesModel.Gpt432k => "gpt-4-32k",
                ModelResponsePropertiesModel.Gpt432k0314 => "gpt-4-32k-0314",
                ModelResponsePropertiesModel.Gpt432k0613 => "gpt-4-32k-0613",
                ModelResponsePropertiesModel.Gpt35Turbo => "gpt-3.5-turbo",
                ModelResponsePropertiesModel.Gpt35Turbo16k => "gpt-3.5-turbo-16k",
                ModelResponsePropertiesModel.Gpt35Turbo0301 => "gpt-3.5-turbo-0301",
                ModelResponsePropertiesModel.Gpt35Turbo0613 => "gpt-3.5-turbo-0613",
                ModelResponsePropertiesModel.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                ModelResponsePropertiesModel.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                ModelResponsePropertiesModel.Gpt35Turbo16k0613 => "gpt-3.5-turbo-16k-0613",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelResponsePropertiesModel? ToEnum(string value)
        {
            return value switch
            {
                "o3-mini" => ModelResponsePropertiesModel.O3Mini,
                "o3-mini-2025-01-31" => ModelResponsePropertiesModel.O3Mini20250131,
                "o1" => ModelResponsePropertiesModel.O1,
                "o1-2024-12-17" => ModelResponsePropertiesModel.O120241217,
                "o1-preview" => ModelResponsePropertiesModel.O1Preview,
                "o1-preview-2024-09-12" => ModelResponsePropertiesModel.O1Preview20240912,
                "o1-mini" => ModelResponsePropertiesModel.O1Mini,
                "o1-mini-2024-09-12" => ModelResponsePropertiesModel.O1Mini20240912,
                "computer-use-preview" => ModelResponsePropertiesModel.ComputerUsePreview,
                "computer-use-preview-2025-02-04" => ModelResponsePropertiesModel.ComputerUsePreview20250204,
                "computer-use-preview-2025-03-11" => ModelResponsePropertiesModel.ComputerUsePreview20250311,
                "gpt-4.5-preview" => ModelResponsePropertiesModel.Gpt45Preview,
                "gpt-4.5-preview-2025-02-27" => ModelResponsePropertiesModel.Gpt45Preview20250227,
                "gpt-4o" => ModelResponsePropertiesModel.Gpt4o,
                "gpt-4o-2024-11-20" => ModelResponsePropertiesModel.Gpt4o20241120,
                "gpt-4o-2024-08-06" => ModelResponsePropertiesModel.Gpt4o20240806,
                "gpt-4o-2024-05-13" => ModelResponsePropertiesModel.Gpt4o20240513,
                "gpt-4o-audio-preview" => ModelResponsePropertiesModel.Gpt4oAudioPreview,
                "gpt-4o-audio-preview-2024-10-01" => ModelResponsePropertiesModel.Gpt4oAudioPreview20241001,
                "gpt-4o-audio-preview-2024-12-17" => ModelResponsePropertiesModel.Gpt4oAudioPreview20241217,
                "gpt-4o-mini-audio-preview" => ModelResponsePropertiesModel.Gpt4oMiniAudioPreview,
                "gpt-4o-mini-audio-preview-2024-12-17" => ModelResponsePropertiesModel.Gpt4oMiniAudioPreview20241217,
                "chatgpt-4o-latest" => ModelResponsePropertiesModel.Chatgpt4oLatest,
                "gpt-4o-mini" => ModelResponsePropertiesModel.Gpt4oMini,
                "gpt-4o-mini-2024-07-18" => ModelResponsePropertiesModel.Gpt4oMini20240718,
                "gpt-4-turbo" => ModelResponsePropertiesModel.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => ModelResponsePropertiesModel.Gpt4Turbo20240409,
                "gpt-4-0125-preview" => ModelResponsePropertiesModel.Gpt40125Preview,
                "gpt-4-turbo-preview" => ModelResponsePropertiesModel.Gpt4TurboPreview,
                "gpt-4-1106-preview" => ModelResponsePropertiesModel.Gpt41106Preview,
                "gpt-4-vision-preview" => ModelResponsePropertiesModel.Gpt4VisionPreview,
                "gpt-4" => ModelResponsePropertiesModel.Gpt4,
                "gpt-4-0314" => ModelResponsePropertiesModel.Gpt40314,
                "gpt-4-0613" => ModelResponsePropertiesModel.Gpt40613,
                "gpt-4-32k" => ModelResponsePropertiesModel.Gpt432k,
                "gpt-4-32k-0314" => ModelResponsePropertiesModel.Gpt432k0314,
                "gpt-4-32k-0613" => ModelResponsePropertiesModel.Gpt432k0613,
                "gpt-3.5-turbo" => ModelResponsePropertiesModel.Gpt35Turbo,
                "gpt-3.5-turbo-16k" => ModelResponsePropertiesModel.Gpt35Turbo16k,
                "gpt-3.5-turbo-0301" => ModelResponsePropertiesModel.Gpt35Turbo0301,
                "gpt-3.5-turbo-0613" => ModelResponsePropertiesModel.Gpt35Turbo0613,
                "gpt-3.5-turbo-1106" => ModelResponsePropertiesModel.Gpt35Turbo1106,
                "gpt-3.5-turbo-0125" => ModelResponsePropertiesModel.Gpt35Turbo0125,
                "gpt-3.5-turbo-16k-0613" => ModelResponsePropertiesModel.Gpt35Turbo16k0613,
                _ => null,
            };
        }
    }
}