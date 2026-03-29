//HintName: G.Models.InflectionAIModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InflectionAIModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        InflectionAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InflectionAIModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InflectionAIModelProvider value)
        {
            return value switch
            {
                InflectionAIModelProvider.InflectionAi => "inflection-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InflectionAIModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "inflection-ai" => InflectionAIModelProvider.InflectionAi,
                _ => null,
            };
        }
    }
}