//HintName: G.Models.CreateChatCompletionRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateChatCompletionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo0125,
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
        Gpt35Turbo16k,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo16k0613,
        /// <summary>
        /// 
        /// </summary>
        Gpt4,
        /// <summary>
        /// 
        /// </summary>
        Gpt40125Preview,
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
        Gpt41106Preview,
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
        Gpt4Turbo,
        /// <summary>
        /// 
        /// </summary>
        Gpt4Turbo20240409,
        /// <summary>
        /// 
        /// </summary>
        Gpt4TurboPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4VisionPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o,
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
        Gpt5,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Nano,
        /// <summary>
        /// 
        /// </summary>
        O1,
        /// <summary>
        /// 
        /// </summary>
        O1Mini,
        /// <summary>
        /// 
        /// </summary>
        O3,
        /// <summary>
        /// 
        /// </summary>
        O3Mini,
        /// <summary>
        /// 
        /// </summary>
        O4Mini,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestModel value)
        {
            return value switch
            {
                CreateChatCompletionRequestModel.Gpt35Turbo => "gpt-3.5-turbo",
                CreateChatCompletionRequestModel.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                CreateChatCompletionRequestModel.Gpt35Turbo0301 => "gpt-3.5-turbo-0301",
                CreateChatCompletionRequestModel.Gpt35Turbo0613 => "gpt-3.5-turbo-0613",
                CreateChatCompletionRequestModel.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                CreateChatCompletionRequestModel.Gpt35Turbo16k => "gpt-3.5-turbo-16k",
                CreateChatCompletionRequestModel.Gpt35Turbo16k0613 => "gpt-3.5-turbo-16k-0613",
                CreateChatCompletionRequestModel.Gpt4 => "gpt-4",
                CreateChatCompletionRequestModel.Gpt40125Preview => "gpt-4-0125-preview",
                CreateChatCompletionRequestModel.Gpt40314 => "gpt-4-0314",
                CreateChatCompletionRequestModel.Gpt40613 => "gpt-4-0613",
                CreateChatCompletionRequestModel.Gpt41106Preview => "gpt-4-1106-preview",
                CreateChatCompletionRequestModel.Gpt432k => "gpt-4-32k",
                CreateChatCompletionRequestModel.Gpt432k0314 => "gpt-4-32k-0314",
                CreateChatCompletionRequestModel.Gpt432k0613 => "gpt-4-32k-0613",
                CreateChatCompletionRequestModel.Gpt4Turbo => "gpt-4-turbo",
                CreateChatCompletionRequestModel.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                CreateChatCompletionRequestModel.Gpt4TurboPreview => "gpt-4-turbo-preview",
                CreateChatCompletionRequestModel.Gpt4VisionPreview => "gpt-4-vision-preview",
                CreateChatCompletionRequestModel.Gpt4o => "gpt-4o",
                CreateChatCompletionRequestModel.Gpt4o20240513 => "gpt-4o-2024-05-13",
                CreateChatCompletionRequestModel.Gpt4oMini => "gpt-4o-mini",
                CreateChatCompletionRequestModel.Gpt5 => "gpt-5",
                CreateChatCompletionRequestModel.Gpt5Mini => "gpt-5-mini",
                CreateChatCompletionRequestModel.Gpt5Nano => "gpt-5-nano",
                CreateChatCompletionRequestModel.O1 => "o1",
                CreateChatCompletionRequestModel.O1Mini => "o1-mini",
                CreateChatCompletionRequestModel.O3 => "o3",
                CreateChatCompletionRequestModel.O3Mini => "o3-mini",
                CreateChatCompletionRequestModel.O4Mini => "o4-mini",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-3.5-turbo" => CreateChatCompletionRequestModel.Gpt35Turbo,
                "gpt-3.5-turbo-0125" => CreateChatCompletionRequestModel.Gpt35Turbo0125,
                "gpt-3.5-turbo-0301" => CreateChatCompletionRequestModel.Gpt35Turbo0301,
                "gpt-3.5-turbo-0613" => CreateChatCompletionRequestModel.Gpt35Turbo0613,
                "gpt-3.5-turbo-1106" => CreateChatCompletionRequestModel.Gpt35Turbo1106,
                "gpt-3.5-turbo-16k" => CreateChatCompletionRequestModel.Gpt35Turbo16k,
                "gpt-3.5-turbo-16k-0613" => CreateChatCompletionRequestModel.Gpt35Turbo16k0613,
                "gpt-4" => CreateChatCompletionRequestModel.Gpt4,
                "gpt-4-0125-preview" => CreateChatCompletionRequestModel.Gpt40125Preview,
                "gpt-4-0314" => CreateChatCompletionRequestModel.Gpt40314,
                "gpt-4-0613" => CreateChatCompletionRequestModel.Gpt40613,
                "gpt-4-1106-preview" => CreateChatCompletionRequestModel.Gpt41106Preview,
                "gpt-4-32k" => CreateChatCompletionRequestModel.Gpt432k,
                "gpt-4-32k-0314" => CreateChatCompletionRequestModel.Gpt432k0314,
                "gpt-4-32k-0613" => CreateChatCompletionRequestModel.Gpt432k0613,
                "gpt-4-turbo" => CreateChatCompletionRequestModel.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => CreateChatCompletionRequestModel.Gpt4Turbo20240409,
                "gpt-4-turbo-preview" => CreateChatCompletionRequestModel.Gpt4TurboPreview,
                "gpt-4-vision-preview" => CreateChatCompletionRequestModel.Gpt4VisionPreview,
                "gpt-4o" => CreateChatCompletionRequestModel.Gpt4o,
                "gpt-4o-2024-05-13" => CreateChatCompletionRequestModel.Gpt4o20240513,
                "gpt-4o-mini" => CreateChatCompletionRequestModel.Gpt4oMini,
                "gpt-5" => CreateChatCompletionRequestModel.Gpt5,
                "gpt-5-mini" => CreateChatCompletionRequestModel.Gpt5Mini,
                "gpt-5-nano" => CreateChatCompletionRequestModel.Gpt5Nano,
                "o1" => CreateChatCompletionRequestModel.O1,
                "o1-mini" => CreateChatCompletionRequestModel.O1Mini,
                "o3" => CreateChatCompletionRequestModel.O3,
                "o3-mini" => CreateChatCompletionRequestModel.O3Mini,
                "o4-mini" => CreateChatCompletionRequestModel.O4Mini,
                _ => null,
            };
        }
    }
}