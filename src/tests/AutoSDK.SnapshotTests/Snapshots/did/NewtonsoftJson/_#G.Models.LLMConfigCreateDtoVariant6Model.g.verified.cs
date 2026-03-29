//HintName: G.Models.LLMConfigCreateDtoVariant6Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LLMConfigCreateDtoVariant6Model
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
    public static class LLMConfigCreateDtoVariant6ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCreateDtoVariant6Model value)
        {
            return value switch
            {
                LLMConfigCreateDtoVariant6Model.Gemini25Flash => "gemini-2.5-flash",
                LLMConfigCreateDtoVariant6Model.Gemini25FlashLite => "gemini-2.5-flash-lite",
                LLMConfigCreateDtoVariant6Model.Gemini3Flash => "gemini-3-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCreateDtoVariant6Model? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.5-flash" => LLMConfigCreateDtoVariant6Model.Gemini25Flash,
                "gemini-2.5-flash-lite" => LLMConfigCreateDtoVariant6Model.Gemini25FlashLite,
                "gemini-3-flash" => LLMConfigCreateDtoVariant6Model.Gemini3Flash,
                _ => null,
            };
        }
    }
}