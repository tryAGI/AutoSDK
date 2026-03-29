//HintName: G.Models.EvalCustomModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider of the model (`custom-llm`).
    /// </summary>
    public enum EvalCustomModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalCustomModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalCustomModelProvider value)
        {
            return value switch
            {
                EvalCustomModelProvider.CustomLlm => "custom-llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalCustomModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-llm" => EvalCustomModelProvider.CustomLlm,
                _ => null,
            };
        }
    }
}