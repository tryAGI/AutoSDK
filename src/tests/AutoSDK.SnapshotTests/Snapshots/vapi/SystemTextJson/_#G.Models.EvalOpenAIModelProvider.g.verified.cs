//HintName: G.Models.EvalOpenAIModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider of the model (`openai`).
    /// </summary>
    public enum EvalOpenAIModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalOpenAIModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalOpenAIModelProvider value)
        {
            return value switch
            {
                EvalOpenAIModelProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalOpenAIModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => EvalOpenAIModelProvider.Openai,
                _ => null,
            };
        }
    }
}