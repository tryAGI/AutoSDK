//HintName: G.Models.UpdateRequestLlmGoogleModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum UpdateRequestLlmGoogleModel
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
    public static class UpdateRequestLlmGoogleModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRequestLlmGoogleModel value)
        {
            return value switch
            {
                UpdateRequestLlmGoogleModel.Gemini25Flash => "gemini-2.5-flash",
                UpdateRequestLlmGoogleModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                UpdateRequestLlmGoogleModel.Gemini3Flash => "gemini-3-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRequestLlmGoogleModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.5-flash" => UpdateRequestLlmGoogleModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => UpdateRequestLlmGoogleModel.Gemini25FlashLite,
                "gemini-3-flash" => UpdateRequestLlmGoogleModel.Gemini3Flash,
                _ => null,
            };
        }
    }
}