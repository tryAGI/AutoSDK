//HintName: G.Models.CreateRunRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRunRequestModel
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRunRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRunRequestModel value)
        {
            return value switch
            {
                CreateRunRequestModel.Gpt4Turbo => "gpt-4-turbo",
                CreateRunRequestModel.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                CreateRunRequestModel.Gpt40125Preview => "gpt-4-0125-preview",
                CreateRunRequestModel.Gpt4TurboPreview => "gpt-4-turbo-preview",
                CreateRunRequestModel.Gpt41106Preview => "gpt-4-1106-preview",
                CreateRunRequestModel.Gpt4VisionPreview => "gpt-4-vision-preview",
                CreateRunRequestModel.Gpt4 => "gpt-4",
                CreateRunRequestModel.Gpt40314 => "gpt-4-0314",
                CreateRunRequestModel.Gpt40613 => "gpt-4-0613",
                CreateRunRequestModel.Gpt432k => "gpt-4-32k",
                CreateRunRequestModel.Gpt432k0314 => "gpt-4-32k-0314",
                CreateRunRequestModel.Gpt432k0613 => "gpt-4-32k-0613",
                CreateRunRequestModel.Gpt35Turbo => "gpt-3.5-turbo",
                CreateRunRequestModel.Gpt35Turbo16k => "gpt-3.5-turbo-16k",
                CreateRunRequestModel.Gpt35Turbo0613 => "gpt-3.5-turbo-0613",
                CreateRunRequestModel.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                CreateRunRequestModel.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                CreateRunRequestModel.Gpt35Turbo16k0613 => "gpt-3.5-turbo-16k-0613",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRunRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4-turbo" => CreateRunRequestModel.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => CreateRunRequestModel.Gpt4Turbo20240409,
                "gpt-4-0125-preview" => CreateRunRequestModel.Gpt40125Preview,
                "gpt-4-turbo-preview" => CreateRunRequestModel.Gpt4TurboPreview,
                "gpt-4-1106-preview" => CreateRunRequestModel.Gpt41106Preview,
                "gpt-4-vision-preview" => CreateRunRequestModel.Gpt4VisionPreview,
                "gpt-4" => CreateRunRequestModel.Gpt4,
                "gpt-4-0314" => CreateRunRequestModel.Gpt40314,
                "gpt-4-0613" => CreateRunRequestModel.Gpt40613,
                "gpt-4-32k" => CreateRunRequestModel.Gpt432k,
                "gpt-4-32k-0314" => CreateRunRequestModel.Gpt432k0314,
                "gpt-4-32k-0613" => CreateRunRequestModel.Gpt432k0613,
                "gpt-3.5-turbo" => CreateRunRequestModel.Gpt35Turbo,
                "gpt-3.5-turbo-16k" => CreateRunRequestModel.Gpt35Turbo16k,
                "gpt-3.5-turbo-0613" => CreateRunRequestModel.Gpt35Turbo0613,
                "gpt-3.5-turbo-1106" => CreateRunRequestModel.Gpt35Turbo1106,
                "gpt-3.5-turbo-0125" => CreateRunRequestModel.Gpt35Turbo0125,
                "gpt-3.5-turbo-16k-0613" => CreateRunRequestModel.Gpt35Turbo16k0613,
                _ => null,
            };
        }
    }
}