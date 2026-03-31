//HintName: G.Models.AgentUpdateDtoLlmGoogleModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum AgentUpdateDtoLlmGoogleModel
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
    public static class AgentUpdateDtoLlmGoogleModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentUpdateDtoLlmGoogleModel value)
        {
            return value switch
            {
                AgentUpdateDtoLlmGoogleModel.Gemini25Flash => "gemini-2.5-flash",
                AgentUpdateDtoLlmGoogleModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                AgentUpdateDtoLlmGoogleModel.Gemini3Flash => "gemini-3-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentUpdateDtoLlmGoogleModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.5-flash" => AgentUpdateDtoLlmGoogleModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => AgentUpdateDtoLlmGoogleModel.Gemini25FlashLite,
                "gemini-3-flash" => AgentUpdateDtoLlmGoogleModel.Gemini3Flash,
                _ => null,
            };
        }
    }
}