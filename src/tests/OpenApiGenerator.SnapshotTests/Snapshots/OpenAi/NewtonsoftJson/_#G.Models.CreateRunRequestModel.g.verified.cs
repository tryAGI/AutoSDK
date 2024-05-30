//HintName: G.Models.CreateRunRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRunRequestModel
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

    public static class CreateRunRequestModelExtensions
    {
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
        public static CreateRunRequestModel ToEnum(string value)
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
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateRunRequestModel ToEnum(int value)
        {
            return value switch
            {
                0 => CreateRunRequestModel.Gpt4Turbo,
                1 => CreateRunRequestModel.Gpt4Turbo20240409,
                2 => CreateRunRequestModel.Gpt40125Preview,
                3 => CreateRunRequestModel.Gpt4TurboPreview,
                4 => CreateRunRequestModel.Gpt41106Preview,
                5 => CreateRunRequestModel.Gpt4VisionPreview,
                6 => CreateRunRequestModel.Gpt4,
                7 => CreateRunRequestModel.Gpt40314,
                8 => CreateRunRequestModel.Gpt40613,
                9 => CreateRunRequestModel.Gpt432k,
                10 => CreateRunRequestModel.Gpt432k0314,
                11 => CreateRunRequestModel.Gpt432k0613,
                12 => CreateRunRequestModel.Gpt35Turbo,
                13 => CreateRunRequestModel.Gpt35Turbo16k,
                14 => CreateRunRequestModel.Gpt35Turbo0613,
                15 => CreateRunRequestModel.Gpt35Turbo1106,
                16 => CreateRunRequestModel.Gpt35Turbo0125,
                17 => CreateRunRequestModel.Gpt35Turbo16k0613,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}