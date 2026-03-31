//HintName: G.Models.GetResponseVariant1LlmGoogleModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum GetResponseVariant1LlmGoogleModel
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
    public static class GetResponseVariant1LlmGoogleModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseVariant1LlmGoogleModel value)
        {
            return value switch
            {
                GetResponseVariant1LlmGoogleModel.Gemini25Flash => "gemini-2.5-flash",
                GetResponseVariant1LlmGoogleModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                GetResponseVariant1LlmGoogleModel.Gemini3Flash => "gemini-3-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseVariant1LlmGoogleModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.5-flash" => GetResponseVariant1LlmGoogleModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => GetResponseVariant1LlmGoogleModel.Gemini25FlashLite,
                "gemini-3-flash" => GetResponseVariant1LlmGoogleModel.Gemini3Flash,
                _ => null,
            };
        }
    }
}