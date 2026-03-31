//HintName: G.Models.GoogleLLMCreateDtoModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum GoogleLLMCreateDtoModel
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
    public static class GoogleLLMCreateDtoModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleLLMCreateDtoModel value)
        {
            return value switch
            {
                GoogleLLMCreateDtoModel.Gemini25Flash => "gemini-2.5-flash",
                GoogleLLMCreateDtoModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                GoogleLLMCreateDtoModel.Gemini3Flash => "gemini-3-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleLLMCreateDtoModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.5-flash" => GoogleLLMCreateDtoModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => GoogleLLMCreateDtoModel.Gemini25FlashLite,
                "gemini-3-flash" => GoogleLLMCreateDtoModel.Gemini3Flash,
                _ => null,
            };
        }
    }
}