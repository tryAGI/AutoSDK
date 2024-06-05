//HintName: G.Models.CreateChatCompletionRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatCompletionRequestModel
    {
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
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-0301")]
        Gpt35Turbo0301,
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
    public static class CreateChatCompletionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestModel? ToEnum(string value)
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
                _ => null,
            };
        }
    }
}