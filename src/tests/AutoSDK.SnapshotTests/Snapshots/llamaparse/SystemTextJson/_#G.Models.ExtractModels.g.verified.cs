//HintName: G.Models.ExtractModels.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Extract model options.
    /// </summary>
    public enum ExtractModels
    {
        /// <summary>
        /// 
        /// </summary>
        Gemini20Flash,
        /// <summary>
        /// 
        /// </summary>
        Gemini25Flash,
        /// <summary>
        /// 
        /// </summary>
        Gemini25FlashLite,
        /// <summary>
        /// 
        /// </summary>
        Gemini25Pro,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGpt41,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGpt4o,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        OpenaiGpt5,
        /// <summary>
        /// 
        /// </summary>
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