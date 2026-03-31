//HintName: G.Models.LLMConfigGoogleModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum LLMConfigGoogleModel
    {
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
        Gemini3Flash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigGoogleModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigGoogleModel value)
        {
            return value switch
            {
                LLMConfigGoogleModel.Gemini25Flash => "gemini-2.5-flash",
                LLMConfigGoogleModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                LLMConfigGoogleModel.Gemini3Flash => "gemini-3-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigGoogleModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.5-flash" => LLMConfigGoogleModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => LLMConfigGoogleModel.Gemini25FlashLite,
                "gemini-3-flash" => LLMConfigGoogleModel.Gemini3Flash,
                _ => null,
            };
        }
    }
}