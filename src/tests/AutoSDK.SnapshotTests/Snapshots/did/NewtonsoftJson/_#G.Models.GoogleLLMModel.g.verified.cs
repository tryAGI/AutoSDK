//HintName: G.Models.GoogleLLMModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Google LLM models
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoogleLLMModel
    {
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
        [global::System.Runtime.Serialization.EnumMember(Value="gemini-3-flash")]
        Gemini3Flash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleLLMModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleLLMModel value)
        {
            return value switch
            {
                GoogleLLMModel.Gemini25Flash => "gemini-2.5-flash",
                GoogleLLMModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                GoogleLLMModel.Gemini3Flash => "gemini-3-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleLLMModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.5-flash" => GoogleLLMModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => GoogleLLMModel.Gemini25FlashLite,
                "gemini-3-flash" => GoogleLLMModel.Gemini3Flash,
                _ => null,
            };
        }
    }
}