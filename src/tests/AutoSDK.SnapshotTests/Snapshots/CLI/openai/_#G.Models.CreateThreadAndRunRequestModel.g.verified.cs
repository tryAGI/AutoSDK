﻿//HintName: G.Models.CreateThreadAndRunRequestModel.g.cs

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
    public static class CreateThreadAndRunRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateThreadAndRunRequestModel value)
        {
            return value switch
            {
                CreateThreadAndRunRequestModel.Gpt41 => "gpt-4.1",
                CreateThreadAndRunRequestModel.Gpt41Mini => "gpt-4.1-mini",
                CreateThreadAndRunRequestModel.Gpt41Nano => "gpt-4.1-nano",
                CreateThreadAndRunRequestModel.Gpt4120250414 => "gpt-4.1-2025-04-14",
                CreateThreadAndRunRequestModel.Gpt41Mini20250414 => "gpt-4.1-mini-2025-04-14",
                CreateThreadAndRunRequestModel.Gpt41Nano20250414 => "gpt-4.1-nano-2025-04-14",
                CreateThreadAndRunRequestModel.Gpt4o => "gpt-4o",
                CreateThreadAndRunRequestModel.Gpt4o20241120 => "gpt-4o-2024-11-20",
                CreateThreadAndRunRequestModel.Gpt4o20240806 => "gpt-4o-2024-08-06",
                CreateThreadAndRunRequestModel.Gpt4o20240513 => "gpt-4o-2024-05-13",
                CreateThreadAndRunRequestModel.Gpt4oMini => "gpt-4o-mini",
                CreateThreadAndRunRequestModel.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                CreateThreadAndRunRequestModel.Gpt45Preview => "gpt-4.5-preview",
                CreateThreadAndRunRequestModel.Gpt45Preview20250227 => "gpt-4.5-preview-2025-02-27",
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateThreadAndRunRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => CreateThreadAndRunRequestModel.Gpt41,
                "gpt-4.1-mini" => CreateThreadAndRunRequestModel.Gpt41Mini,
                "gpt-4.1-nano" => CreateThreadAndRunRequestModel.Gpt41Nano,
                "gpt-4.1-2025-04-14" => CreateThreadAndRunRequestModel.Gpt4120250414,
                "gpt-4.1-mini-2025-04-14" => CreateThreadAndRunRequestModel.Gpt41Mini20250414,
                "gpt-4.1-nano-2025-04-14" => CreateThreadAndRunRequestModel.Gpt41Nano20250414,
                "gpt-4o" => CreateThreadAndRunRequestModel.Gpt4o,
                "gpt-4o-2024-11-20" => CreateThreadAndRunRequestModel.Gpt4o20241120,
                "gpt-4o-2024-08-06" => CreateThreadAndRunRequestModel.Gpt4o20240806,
                "gpt-4o-2024-05-13" => CreateThreadAndRunRequestModel.Gpt4o20240513,
                "gpt-4o-mini" => CreateThreadAndRunRequestModel.Gpt4oMini,
                "gpt-4o-mini-2024-07-18" => CreateThreadAndRunRequestModel.Gpt4oMini20240718,
                "gpt-4.5-preview" => CreateThreadAndRunRequestModel.Gpt45Preview,
                "gpt-4.5-preview-2025-02-27" => CreateThreadAndRunRequestModel.Gpt45Preview20250227,
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
                _ => null,
            };
        }
    }
}