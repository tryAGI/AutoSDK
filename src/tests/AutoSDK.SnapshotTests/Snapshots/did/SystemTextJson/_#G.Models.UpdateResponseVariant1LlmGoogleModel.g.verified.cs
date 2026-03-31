//HintName: G.Models.UpdateResponseVariant1LlmGoogleModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum UpdateResponseVariant1LlmGoogleModel
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
    public static class UpdateResponseVariant1LlmGoogleModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1LlmGoogleModel value)
        {
            return value switch
            {
                UpdateResponseVariant1LlmGoogleModel.Gemini25Flash => "gemini-2.5-flash",
                UpdateResponseVariant1LlmGoogleModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                UpdateResponseVariant1LlmGoogleModel.Gemini3Flash => "gemini-3-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1LlmGoogleModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.5-flash" => UpdateResponseVariant1LlmGoogleModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => UpdateResponseVariant1LlmGoogleModel.Gemini25FlashLite,
                "gemini-3-flash" => UpdateResponseVariant1LlmGoogleModel.Gemini3Flash,
                _ => null,
            };
        }
    }
}