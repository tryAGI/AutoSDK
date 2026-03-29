//HintName: G.Models.DeleteResponseVariant1LlmGoogleModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteResponseVariant1LlmGoogleModel
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
    public static class DeleteResponseVariant1LlmGoogleModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteResponseVariant1LlmGoogleModel value)
        {
            return value switch
            {
                DeleteResponseVariant1LlmGoogleModel.Gemini25Flash => "gemini-2.5-flash",
                DeleteResponseVariant1LlmGoogleModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                DeleteResponseVariant1LlmGoogleModel.Gemini3Flash => "gemini-3-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteResponseVariant1LlmGoogleModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.5-flash" => DeleteResponseVariant1LlmGoogleModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => DeleteResponseVariant1LlmGoogleModel.Gemini25FlashLite,
                "gemini-3-flash" => DeleteResponseVariant1LlmGoogleModel.Gemini3Flash,
                _ => null,
            };
        }
    }
}