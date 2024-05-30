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

    public static class CreateChatCompletionRequestModelExtensions
    {
        public static string ToValueString(this CreateChatCompletionRequestModel value)
        {
            return value switch
            {
                CreateChatCompletionRequestModel.Gpt4Turbo => "gpt-4-turbo",
                CreateChatCompletionRequestModel.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                CreateChatCompletionRequestModel.Gpt40125Preview => "gpt-4-0125-preview",
                CreateChatCompletionRequestModel.Gpt4TurboPreview => "gpt-4-turbo-preview",
                CreateChatCompletionRequestModel.Gpt41106Preview => "gpt-4-1106-preview",
                CreateChatCompletionRequestModel.Gpt4VisionPreview => "gpt-4-vision-preview",
                CreateChatCompletionRequestModel.Gpt4 => "gpt-4",
                CreateChatCompletionRequestModel.Gpt40314 => "gpt-4-0314",
                CreateChatCompletionRequestModel.Gpt40613 => "gpt-4-0613",
                CreateChatCompletionRequestModel.Gpt432k => "gpt-4-32k",
                CreateChatCompletionRequestModel.Gpt432k0314 => "gpt-4-32k-0314",
                CreateChatCompletionRequestModel.Gpt432k0613 => "gpt-4-32k-0613",
                CreateChatCompletionRequestModel.Gpt35Turbo => "gpt-3.5-turbo",
                CreateChatCompletionRequestModel.Gpt35Turbo16k => "gpt-3.5-turbo-16k",
                CreateChatCompletionRequestModel.Gpt35Turbo0301 => "gpt-3.5-turbo-0301",
                CreateChatCompletionRequestModel.Gpt35Turbo0613 => "gpt-3.5-turbo-0613",
                CreateChatCompletionRequestModel.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                CreateChatCompletionRequestModel.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                CreateChatCompletionRequestModel.Gpt35Turbo16k0613 => "gpt-3.5-turbo-16k-0613",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionRequestModel ToEnum(string value)
        {
            return value switch
            {
                "gpt-4-turbo" => CreateChatCompletionRequestModel.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => CreateChatCompletionRequestModel.Gpt4Turbo20240409,
                "gpt-4-0125-preview" => CreateChatCompletionRequestModel.Gpt40125Preview,
                "gpt-4-turbo-preview" => CreateChatCompletionRequestModel.Gpt4TurboPreview,
                "gpt-4-1106-preview" => CreateChatCompletionRequestModel.Gpt41106Preview,
                "gpt-4-vision-preview" => CreateChatCompletionRequestModel.Gpt4VisionPreview,
                "gpt-4" => CreateChatCompletionRequestModel.Gpt4,
                "gpt-4-0314" => CreateChatCompletionRequestModel.Gpt40314,
                "gpt-4-0613" => CreateChatCompletionRequestModel.Gpt40613,
                "gpt-4-32k" => CreateChatCompletionRequestModel.Gpt432k,
                "gpt-4-32k-0314" => CreateChatCompletionRequestModel.Gpt432k0314,
                "gpt-4-32k-0613" => CreateChatCompletionRequestModel.Gpt432k0613,
                "gpt-3.5-turbo" => CreateChatCompletionRequestModel.Gpt35Turbo,
                "gpt-3.5-turbo-16k" => CreateChatCompletionRequestModel.Gpt35Turbo16k,
                "gpt-3.5-turbo-0301" => CreateChatCompletionRequestModel.Gpt35Turbo0301,
                "gpt-3.5-turbo-0613" => CreateChatCompletionRequestModel.Gpt35Turbo0613,
                "gpt-3.5-turbo-1106" => CreateChatCompletionRequestModel.Gpt35Turbo1106,
                "gpt-3.5-turbo-0125" => CreateChatCompletionRequestModel.Gpt35Turbo0125,
                "gpt-3.5-turbo-16k-0613" => CreateChatCompletionRequestModel.Gpt35Turbo16k0613,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateChatCompletionRequestModel ToEnum(int value)
        {
            return value switch
            {
                0 => CreateChatCompletionRequestModel.Gpt4Turbo,
                1 => CreateChatCompletionRequestModel.Gpt4Turbo20240409,
                2 => CreateChatCompletionRequestModel.Gpt40125Preview,
                3 => CreateChatCompletionRequestModel.Gpt4TurboPreview,
                4 => CreateChatCompletionRequestModel.Gpt41106Preview,
                5 => CreateChatCompletionRequestModel.Gpt4VisionPreview,
                6 => CreateChatCompletionRequestModel.Gpt4,
                7 => CreateChatCompletionRequestModel.Gpt40314,
                8 => CreateChatCompletionRequestModel.Gpt40613,
                9 => CreateChatCompletionRequestModel.Gpt432k,
                10 => CreateChatCompletionRequestModel.Gpt432k0314,
                11 => CreateChatCompletionRequestModel.Gpt432k0613,
                12 => CreateChatCompletionRequestModel.Gpt35Turbo,
                13 => CreateChatCompletionRequestModel.Gpt35Turbo16k,
                14 => CreateChatCompletionRequestModel.Gpt35Turbo0301,
                15 => CreateChatCompletionRequestModel.Gpt35Turbo0613,
                16 => CreateChatCompletionRequestModel.Gpt35Turbo1106,
                17 => CreateChatCompletionRequestModel.Gpt35Turbo0125,
                18 => CreateChatCompletionRequestModel.Gpt35Turbo16k0613,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}