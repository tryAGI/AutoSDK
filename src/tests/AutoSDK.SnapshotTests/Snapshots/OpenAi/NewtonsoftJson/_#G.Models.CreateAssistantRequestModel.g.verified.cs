//HintName: G.Models.CreateAssistantRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAssistantRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o")]
        Gpt4o,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-08-06")]
        Gpt4o20240806,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-05-13")]
        Gpt4o20240513,
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
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-0125-preview")]
        Gpt40125Preview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-turbo-preview")]
        Gpt4TurboPreview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-1106-preview")]
        Gpt41106Preview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-vision-preview")]
        Gpt4VisionPreview,
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
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-32k")]
        Gpt432k,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-32k-0314")]
        Gpt432k0314,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-32k-0613")]
        Gpt432k0613,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo")]
        Gpt35Turbo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-16k")]
        Gpt35Turbo16k,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-0613")]
        Gpt35Turbo0613,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-1106")]
        Gpt35Turbo1106,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-0125")]
        Gpt35Turbo0125,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-16k-0613")]
        Gpt35Turbo16k0613,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssistantRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantRequestModel value)
        {
            return value switch
            {
                CreateAssistantRequestModel.Gpt4o => "gpt-4o",
                CreateAssistantRequestModel.Gpt4o20240806 => "gpt-4o-2024-08-06",
                CreateAssistantRequestModel.Gpt4o20240513 => "gpt-4o-2024-05-13",
                CreateAssistantRequestModel.Gpt4oMini => "gpt-4o-mini",
                CreateAssistantRequestModel.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                CreateAssistantRequestModel.Gpt4Turbo => "gpt-4-turbo",
                CreateAssistantRequestModel.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                CreateAssistantRequestModel.Gpt40125Preview => "gpt-4-0125-preview",
                CreateAssistantRequestModel.Gpt4TurboPreview => "gpt-4-turbo-preview",
                CreateAssistantRequestModel.Gpt41106Preview => "gpt-4-1106-preview",
                CreateAssistantRequestModel.Gpt4VisionPreview => "gpt-4-vision-preview",
                CreateAssistantRequestModel.Gpt4 => "gpt-4",
                CreateAssistantRequestModel.Gpt40314 => "gpt-4-0314",
                CreateAssistantRequestModel.Gpt40613 => "gpt-4-0613",
                CreateAssistantRequestModel.Gpt432k => "gpt-4-32k",
                CreateAssistantRequestModel.Gpt432k0314 => "gpt-4-32k-0314",
                CreateAssistantRequestModel.Gpt432k0613 => "gpt-4-32k-0613",
                CreateAssistantRequestModel.Gpt35Turbo => "gpt-3.5-turbo",
                CreateAssistantRequestModel.Gpt35Turbo16k => "gpt-3.5-turbo-16k",
                CreateAssistantRequestModel.Gpt35Turbo0613 => "gpt-3.5-turbo-0613",
                CreateAssistantRequestModel.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                CreateAssistantRequestModel.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                CreateAssistantRequestModel.Gpt35Turbo16k0613 => "gpt-3.5-turbo-16k-0613",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o" => CreateAssistantRequestModel.Gpt4o,
                "gpt-4o-2024-08-06" => CreateAssistantRequestModel.Gpt4o20240806,
                "gpt-4o-2024-05-13" => CreateAssistantRequestModel.Gpt4o20240513,
                "gpt-4o-mini" => CreateAssistantRequestModel.Gpt4oMini,
                "gpt-4o-mini-2024-07-18" => CreateAssistantRequestModel.Gpt4oMini20240718,
                "gpt-4-turbo" => CreateAssistantRequestModel.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => CreateAssistantRequestModel.Gpt4Turbo20240409,
                "gpt-4-0125-preview" => CreateAssistantRequestModel.Gpt40125Preview,
                "gpt-4-turbo-preview" => CreateAssistantRequestModel.Gpt4TurboPreview,
                "gpt-4-1106-preview" => CreateAssistantRequestModel.Gpt41106Preview,
                "gpt-4-vision-preview" => CreateAssistantRequestModel.Gpt4VisionPreview,
                "gpt-4" => CreateAssistantRequestModel.Gpt4,
                "gpt-4-0314" => CreateAssistantRequestModel.Gpt40314,
                "gpt-4-0613" => CreateAssistantRequestModel.Gpt40613,
                "gpt-4-32k" => CreateAssistantRequestModel.Gpt432k,
                "gpt-4-32k-0314" => CreateAssistantRequestModel.Gpt432k0314,
                "gpt-4-32k-0613" => CreateAssistantRequestModel.Gpt432k0613,
                "gpt-3.5-turbo" => CreateAssistantRequestModel.Gpt35Turbo,
                "gpt-3.5-turbo-16k" => CreateAssistantRequestModel.Gpt35Turbo16k,
                "gpt-3.5-turbo-0613" => CreateAssistantRequestModel.Gpt35Turbo0613,
                "gpt-3.5-turbo-1106" => CreateAssistantRequestModel.Gpt35Turbo1106,
                "gpt-3.5-turbo-0125" => CreateAssistantRequestModel.Gpt35Turbo0125,
                "gpt-3.5-turbo-16k-0613" => CreateAssistantRequestModel.Gpt35Turbo16k0613,
                _ => null,
            };
        }
    }
}