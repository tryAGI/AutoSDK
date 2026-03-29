//HintName: G.Models.AzureOpenAICredentialModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AzureOpenAICredentialModel
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
    public static class AzureOpenAICredentialModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureOpenAICredentialModel value)
        {
            return value switch
            {
                AzureOpenAICredentialModel.Gpt35Turbo0125 => "gpt-35-turbo-0125",
                AzureOpenAICredentialModel.Gpt35Turbo1106 => "gpt-35-turbo-1106",
                AzureOpenAICredentialModel.Gpt40125Preview => "gpt-4-0125-preview",
                AzureOpenAICredentialModel.Gpt40613 => "gpt-4-0613",
                AzureOpenAICredentialModel.Gpt41106Preview => "gpt-4-1106-preview",
                AzureOpenAICredentialModel.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                AzureOpenAICredentialModel.Gpt4120250414 => "gpt-4.1-2025-04-14",
                AzureOpenAICredentialModel.Gpt41Mini20250414 => "gpt-4.1-mini-2025-04-14",
                AzureOpenAICredentialModel.Gpt41Nano20250414 => "gpt-4.1-nano-2025-04-14",
                AzureOpenAICredentialModel.Gpt4o20240513 => "gpt-4o-2024-05-13",
                AzureOpenAICredentialModel.Gpt4o20240806 => "gpt-4o-2024-08-06",
                AzureOpenAICredentialModel.Gpt4o20241120 => "gpt-4o-2024-11-20",
                AzureOpenAICredentialModel.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                AzureOpenAICredentialModel.Gpt5 => "gpt-5",
                AzureOpenAICredentialModel.Gpt5Mini => "gpt-5-mini",
                AzureOpenAICredentialModel.Gpt5Nano => "gpt-5-nano",
                AzureOpenAICredentialModel.Gpt51 => "gpt-5.1",
                AzureOpenAICredentialModel.Gpt51Chat => "gpt-5.1-chat",
                AzureOpenAICredentialModel.Gpt52 => "gpt-5.2",
                AzureOpenAICredentialModel.Gpt52Chat => "gpt-5.2-chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureOpenAICredentialModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-35-turbo-0125" => AzureOpenAICredentialModel.Gpt35Turbo0125,
                "gpt-35-turbo-1106" => AzureOpenAICredentialModel.Gpt35Turbo1106,
                "gpt-4-0125-preview" => AzureOpenAICredentialModel.Gpt40125Preview,
                "gpt-4-0613" => AzureOpenAICredentialModel.Gpt40613,
                "gpt-4-1106-preview" => AzureOpenAICredentialModel.Gpt41106Preview,
                "gpt-4-turbo-2024-04-09" => AzureOpenAICredentialModel.Gpt4Turbo20240409,
                "gpt-4.1-2025-04-14" => AzureOpenAICredentialModel.Gpt4120250414,
                "gpt-4.1-mini-2025-04-14" => AzureOpenAICredentialModel.Gpt41Mini20250414,
                "gpt-4.1-nano-2025-04-14" => AzureOpenAICredentialModel.Gpt41Nano20250414,
                "gpt-4o-2024-05-13" => AzureOpenAICredentialModel.Gpt4o20240513,
                "gpt-4o-2024-08-06" => AzureOpenAICredentialModel.Gpt4o20240806,
                "gpt-4o-2024-11-20" => AzureOpenAICredentialModel.Gpt4o20241120,
                "gpt-4o-mini-2024-07-18" => AzureOpenAICredentialModel.Gpt4oMini20240718,
                "gpt-5" => AzureOpenAICredentialModel.Gpt5,
                "gpt-5-mini" => AzureOpenAICredentialModel.Gpt5Mini,
                "gpt-5-nano" => AzureOpenAICredentialModel.Gpt5Nano,
                "gpt-5.1" => AzureOpenAICredentialModel.Gpt51,
                "gpt-5.1-chat" => AzureOpenAICredentialModel.Gpt51Chat,
                "gpt-5.2" => AzureOpenAICredentialModel.Gpt52,
                "gpt-5.2-chat" => AzureOpenAICredentialModel.Gpt52Chat,
                _ => null,
            };
        }
    }
}