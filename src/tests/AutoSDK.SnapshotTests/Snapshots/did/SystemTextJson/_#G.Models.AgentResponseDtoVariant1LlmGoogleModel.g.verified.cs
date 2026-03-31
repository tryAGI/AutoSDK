//HintName: G.Models.AgentResponseDtoVariant1LlmGoogleModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum AgentResponseDtoVariant1LlmGoogleModel
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
    public static class AgentResponseDtoVariant1LlmGoogleModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1LlmGoogleModel value)
        {
            return value switch
            {
                AgentResponseDtoVariant1LlmGoogleModel.Gemini25Flash => "gemini-2.5-flash",
                AgentResponseDtoVariant1LlmGoogleModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                AgentResponseDtoVariant1LlmGoogleModel.Gemini3Flash => "gemini-3-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1LlmGoogleModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.5-flash" => AgentResponseDtoVariant1LlmGoogleModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => AgentResponseDtoVariant1LlmGoogleModel.Gemini25FlashLite,
                "gemini-3-flash" => AgentResponseDtoVariant1LlmGoogleModel.Gemini3Flash,
                _ => null,
            };
        }
    }
}