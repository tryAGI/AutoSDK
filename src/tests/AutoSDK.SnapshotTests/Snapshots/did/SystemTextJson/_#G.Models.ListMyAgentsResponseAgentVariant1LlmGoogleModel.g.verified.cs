//HintName: G.Models.ListMyAgentsResponseAgentVariant1LlmGoogleModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use
    /// </summary>
    public enum ListMyAgentsResponseAgentVariant1LlmGoogleModel
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
    public static class ListMyAgentsResponseAgentVariant1LlmGoogleModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1LlmGoogleModel value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1LlmGoogleModel.Gemini25Flash => "gemini-2.5-flash",
                ListMyAgentsResponseAgentVariant1LlmGoogleModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                ListMyAgentsResponseAgentVariant1LlmGoogleModel.Gemini3Flash => "gemini-3-flash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1LlmGoogleModel? ToEnum(string value)
        {
            return value switch
            {
                "gemini-2.5-flash" => ListMyAgentsResponseAgentVariant1LlmGoogleModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => ListMyAgentsResponseAgentVariant1LlmGoogleModel.Gemini25FlashLite,
                "gemini-3-flash" => ListMyAgentsResponseAgentVariant1LlmGoogleModel.Gemini3Flash,
                _ => null,
            };
        }
    }
}