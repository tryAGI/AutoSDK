//HintName: G.Models.AgentLlmGoogleModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum AgentLlmGoogleModel
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
    public static class AgentLlmGoogleModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentLlmGoogleModel value)
        {
            return value switch
            {
                AgentLlmGoogleModel.Gemini25Flash => "gemini-2.5-flash",
                AgentLlmGoogleModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                AgentLlmGoogleModel.Gemini3Flash => "gemini-3-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentLlmGoogleModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.5-flash" => AgentLlmGoogleModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => AgentLlmGoogleModel.Gemini25FlashLite,
                "gemini-3-flash" => AgentLlmGoogleModel.Gemini3Flash,
                _ => null,
            };
        }
    }
}