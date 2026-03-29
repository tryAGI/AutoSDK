//HintName: G.Models.ExtractModels.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Extract model options.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtractModels
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.0-flash")]
        Gemini20Flash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.5-flash")]
        Gemini25Flash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.5-flash-lite")]
        Gemini25FlashLite,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-2.5-pro")]
        Gemini25Pro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-4-1")]
        OpenaiGpt41,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-4-1-mini")]
        OpenaiGpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-4-1-nano")]
        OpenaiGpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-4o")]
        OpenaiGpt4o,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-4o-mini")]
        OpenaiGpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-5")]
        OpenaiGpt5,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-gpt-5-mini")]
        OpenaiGpt5Mini,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractModelsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractModels value)
        {
            return value switch
            {
                ExtractModels.Gemini20Flash => "gemini-2.0-flash",
                ExtractModels.Gemini25Flash => "gemini-2.5-flash",
                ExtractModels.Gemini25FlashLite => "gemini-2.5-flash-lite",
                ExtractModels.Gemini25Pro => "gemini-2.5-pro",
                ExtractModels.OpenaiGpt41 => "openai-gpt-4-1",
                ExtractModels.OpenaiGpt41Mini => "openai-gpt-4-1-mini",
                ExtractModels.OpenaiGpt41Nano => "openai-gpt-4-1-nano",
                ExtractModels.OpenaiGpt4o => "openai-gpt-4o",
                ExtractModels.OpenaiGpt4oMini => "openai-gpt-4o-mini",
                ExtractModels.OpenaiGpt5 => "openai-gpt-5",
                ExtractModels.OpenaiGpt5Mini => "openai-gpt-5-mini",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractModels? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.0-flash" => ExtractModels.Gemini20Flash,
                "gemini-2.5-flash" => ExtractModels.Gemini25Flash,
                "gemini-2.5-flash-lite" => ExtractModels.Gemini25FlashLite,
                "gemini-2.5-pro" => ExtractModels.Gemini25Pro,
                "openai-gpt-4-1" => ExtractModels.OpenaiGpt41,
                "openai-gpt-4-1-mini" => ExtractModels.OpenaiGpt41Mini,
                "openai-gpt-4-1-nano" => ExtractModels.OpenaiGpt41Nano,
                "openai-gpt-4o" => ExtractModels.OpenaiGpt4o,
                "openai-gpt-4o-mini" => ExtractModels.OpenaiGpt4oMini,
                "openai-gpt-5" => ExtractModels.OpenaiGpt5,
                "openai-gpt-5-mini" => ExtractModels.OpenaiGpt5Mini,
                _ => null,
            };
        }
    }
}