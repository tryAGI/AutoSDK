//HintName: G.Models.UpdateAzureOpenAICredentialDTOModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateAzureOpenAICredentialDTOModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-35-turbo-0125")]
        Gpt35Turbo0125,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-35-turbo-1106")]
        Gpt35Turbo1106,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-0125-preview")]
        Gpt40125Preview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-0613")]
        Gpt40613,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-1106-preview")]
        Gpt41106Preview,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4-turbo-2024-04-09")]
        Gpt4Turbo20240409,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-2025-04-14")]
        Gpt4120250414,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-mini-2025-04-14")]
        Gpt41Mini20250414,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4.1-nano-2025-04-14")]
        Gpt41Nano20250414,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-05-13")]
        Gpt4o20240513,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-08-06")]
        Gpt4o20240806,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-2024-11-20")]
        Gpt4o20241120,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-4o-mini-2024-07-18")]
        Gpt4oMini20240718,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5")]
        Gpt5,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5-mini")]
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5-nano")]
        Gpt5Nano,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5.1")]
        Gpt51,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5.1-chat")]
        Gpt51Chat,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5.2")]
        Gpt52,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-5.2-chat")]
        Gpt52Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAzureOpenAICredentialDTOModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAzureOpenAICredentialDTOModel value)
        {
            return value switch
            {
                UpdateAzureOpenAICredentialDTOModel.Gpt35Turbo0125 => "gpt-35-turbo-0125",
                UpdateAzureOpenAICredentialDTOModel.Gpt35Turbo1106 => "gpt-35-turbo-1106",
                UpdateAzureOpenAICredentialDTOModel.Gpt40125Preview => "gpt-4-0125-preview",
                UpdateAzureOpenAICredentialDTOModel.Gpt40613 => "gpt-4-0613",
                UpdateAzureOpenAICredentialDTOModel.Gpt41106Preview => "gpt-4-1106-preview",
                UpdateAzureOpenAICredentialDTOModel.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                UpdateAzureOpenAICredentialDTOModel.Gpt4120250414 => "gpt-4.1-2025-04-14",
                UpdateAzureOpenAICredentialDTOModel.Gpt41Mini20250414 => "gpt-4.1-mini-2025-04-14",
                UpdateAzureOpenAICredentialDTOModel.Gpt41Nano20250414 => "gpt-4.1-nano-2025-04-14",
                UpdateAzureOpenAICredentialDTOModel.Gpt4o20240513 => "gpt-4o-2024-05-13",
                UpdateAzureOpenAICredentialDTOModel.Gpt4o20240806 => "gpt-4o-2024-08-06",
                UpdateAzureOpenAICredentialDTOModel.Gpt4o20241120 => "gpt-4o-2024-11-20",
                UpdateAzureOpenAICredentialDTOModel.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                UpdateAzureOpenAICredentialDTOModel.Gpt5 => "gpt-5",
                UpdateAzureOpenAICredentialDTOModel.Gpt5Mini => "gpt-5-mini",
                UpdateAzureOpenAICredentialDTOModel.Gpt5Nano => "gpt-5-nano",
                UpdateAzureOpenAICredentialDTOModel.Gpt51 => "gpt-5.1",
                UpdateAzureOpenAICredentialDTOModel.Gpt51Chat => "gpt-5.1-chat",
                UpdateAzureOpenAICredentialDTOModel.Gpt52 => "gpt-5.2",
                UpdateAzureOpenAICredentialDTOModel.Gpt52Chat => "gpt-5.2-chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAzureOpenAICredentialDTOModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-35-turbo-0125" => UpdateAzureOpenAICredentialDTOModel.Gpt35Turbo0125,
                "gpt-35-turbo-1106" => UpdateAzureOpenAICredentialDTOModel.Gpt35Turbo1106,
                "gpt-4-0125-preview" => UpdateAzureOpenAICredentialDTOModel.Gpt40125Preview,
                "gpt-4-0613" => UpdateAzureOpenAICredentialDTOModel.Gpt40613,
                "gpt-4-1106-preview" => UpdateAzureOpenAICredentialDTOModel.Gpt41106Preview,
                "gpt-4-turbo-2024-04-09" => UpdateAzureOpenAICredentialDTOModel.Gpt4Turbo20240409,
                "gpt-4.1-2025-04-14" => UpdateAzureOpenAICredentialDTOModel.Gpt4120250414,
                "gpt-4.1-mini-2025-04-14" => UpdateAzureOpenAICredentialDTOModel.Gpt41Mini20250414,
                "gpt-4.1-nano-2025-04-14" => UpdateAzureOpenAICredentialDTOModel.Gpt41Nano20250414,
                "gpt-4o-2024-05-13" => UpdateAzureOpenAICredentialDTOModel.Gpt4o20240513,
                "gpt-4o-2024-08-06" => UpdateAzureOpenAICredentialDTOModel.Gpt4o20240806,
                "gpt-4o-2024-11-20" => UpdateAzureOpenAICredentialDTOModel.Gpt4o20241120,
                "gpt-4o-mini-2024-07-18" => UpdateAzureOpenAICredentialDTOModel.Gpt4oMini20240718,
                "gpt-5" => UpdateAzureOpenAICredentialDTOModel.Gpt5,
                "gpt-5-mini" => UpdateAzureOpenAICredentialDTOModel.Gpt5Mini,
                "gpt-5-nano" => UpdateAzureOpenAICredentialDTOModel.Gpt5Nano,
                "gpt-5.1" => UpdateAzureOpenAICredentialDTOModel.Gpt51,
                "gpt-5.1-chat" => UpdateAzureOpenAICredentialDTOModel.Gpt51Chat,
                "gpt-5.2" => UpdateAzureOpenAICredentialDTOModel.Gpt52,
                "gpt-5.2-chat" => UpdateAzureOpenAICredentialDTOModel.Gpt52Chat,
                _ => null,
            };
        }
    }
}