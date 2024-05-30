//HintName: G.Models.CreateThreadAndRunRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateThreadAndRunRequestModel
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

    public static class CreateThreadAndRunRequestModelExtensions
    {
        public static string ToValueString(this CreateThreadAndRunRequestModel value)
        {
            return value switch
            {
                CreateThreadAndRunRequestModel.Gpt4Turbo => "gpt-4-turbo",
                CreateThreadAndRunRequestModel.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                CreateThreadAndRunRequestModel.Gpt40125Preview => "gpt-4-0125-preview",
                CreateThreadAndRunRequestModel.Gpt4TurboPreview => "gpt-4-turbo-preview",
                CreateThreadAndRunRequestModel.Gpt41106Preview => "gpt-4-1106-preview",
                CreateThreadAndRunRequestModel.Gpt4VisionPreview => "gpt-4-vision-preview",
                CreateThreadAndRunRequestModel.Gpt4 => "gpt-4",
                CreateThreadAndRunRequestModel.Gpt40314 => "gpt-4-0314",
                CreateThreadAndRunRequestModel.Gpt40613 => "gpt-4-0613",
                CreateThreadAndRunRequestModel.Gpt432k => "gpt-4-32k",
                CreateThreadAndRunRequestModel.Gpt432k0314 => "gpt-4-32k-0314",
                CreateThreadAndRunRequestModel.Gpt432k0613 => "gpt-4-32k-0613",
                CreateThreadAndRunRequestModel.Gpt35Turbo => "gpt-3.5-turbo",
                CreateThreadAndRunRequestModel.Gpt35Turbo16k => "gpt-3.5-turbo-16k",
                CreateThreadAndRunRequestModel.Gpt35Turbo0613 => "gpt-3.5-turbo-0613",
                CreateThreadAndRunRequestModel.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                CreateThreadAndRunRequestModel.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                CreateThreadAndRunRequestModel.Gpt35Turbo16k0613 => "gpt-3.5-turbo-16k-0613",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateThreadAndRunRequestModel ToEnum(string value)
        {
            return value switch
            {
                "gpt-4-turbo" => CreateThreadAndRunRequestModel.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => CreateThreadAndRunRequestModel.Gpt4Turbo20240409,
                "gpt-4-0125-preview" => CreateThreadAndRunRequestModel.Gpt40125Preview,
                "gpt-4-turbo-preview" => CreateThreadAndRunRequestModel.Gpt4TurboPreview,
                "gpt-4-1106-preview" => CreateThreadAndRunRequestModel.Gpt41106Preview,
                "gpt-4-vision-preview" => CreateThreadAndRunRequestModel.Gpt4VisionPreview,
                "gpt-4" => CreateThreadAndRunRequestModel.Gpt4,
                "gpt-4-0314" => CreateThreadAndRunRequestModel.Gpt40314,
                "gpt-4-0613" => CreateThreadAndRunRequestModel.Gpt40613,
                "gpt-4-32k" => CreateThreadAndRunRequestModel.Gpt432k,
                "gpt-4-32k-0314" => CreateThreadAndRunRequestModel.Gpt432k0314,
                "gpt-4-32k-0613" => CreateThreadAndRunRequestModel.Gpt432k0613,
                "gpt-3.5-turbo" => CreateThreadAndRunRequestModel.Gpt35Turbo,
                "gpt-3.5-turbo-16k" => CreateThreadAndRunRequestModel.Gpt35Turbo16k,
                "gpt-3.5-turbo-0613" => CreateThreadAndRunRequestModel.Gpt35Turbo0613,
                "gpt-3.5-turbo-1106" => CreateThreadAndRunRequestModel.Gpt35Turbo1106,
                "gpt-3.5-turbo-0125" => CreateThreadAndRunRequestModel.Gpt35Turbo0125,
                "gpt-3.5-turbo-16k-0613" => CreateThreadAndRunRequestModel.Gpt35Turbo16k0613,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateThreadAndRunRequestModel ToEnum(int value)
        {
            return value switch
            {
                0 => CreateThreadAndRunRequestModel.Gpt4Turbo,
                1 => CreateThreadAndRunRequestModel.Gpt4Turbo20240409,
                2 => CreateThreadAndRunRequestModel.Gpt40125Preview,
                3 => CreateThreadAndRunRequestModel.Gpt4TurboPreview,
                4 => CreateThreadAndRunRequestModel.Gpt41106Preview,
                5 => CreateThreadAndRunRequestModel.Gpt4VisionPreview,
                6 => CreateThreadAndRunRequestModel.Gpt4,
                7 => CreateThreadAndRunRequestModel.Gpt40314,
                8 => CreateThreadAndRunRequestModel.Gpt40613,
                9 => CreateThreadAndRunRequestModel.Gpt432k,
                10 => CreateThreadAndRunRequestModel.Gpt432k0314,
                11 => CreateThreadAndRunRequestModel.Gpt432k0613,
                12 => CreateThreadAndRunRequestModel.Gpt35Turbo,
                13 => CreateThreadAndRunRequestModel.Gpt35Turbo16k,
                14 => CreateThreadAndRunRequestModel.Gpt35Turbo0613,
                15 => CreateThreadAndRunRequestModel.Gpt35Turbo1106,
                16 => CreateThreadAndRunRequestModel.Gpt35Turbo0125,
                17 => CreateThreadAndRunRequestModel.Gpt35Turbo16k0613,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}