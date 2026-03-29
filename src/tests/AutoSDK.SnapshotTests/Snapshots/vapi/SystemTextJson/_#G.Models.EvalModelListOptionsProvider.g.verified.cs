//HintName: G.Models.EvalModelListOptionsProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider of the model.
    /// </summary>
    public enum EvalModelListOptionsProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalModelListOptionsProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalModelListOptionsProvider value)
        {
            return value switch
            {
                EvalModelListOptionsProvider.Anthropic => "anthropic",
                EvalModelListOptionsProvider.CustomLlm => "custom-llm",
                EvalModelListOptionsProvider.Google => "google",
                EvalModelListOptionsProvider.Groq => "groq",
                EvalModelListOptionsProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalModelListOptionsProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => EvalModelListOptionsProvider.Anthropic,
                "custom-llm" => EvalModelListOptionsProvider.CustomLlm,
                "google" => EvalModelListOptionsProvider.Google,
                "groq" => EvalModelListOptionsProvider.Groq,
                "openai" => EvalModelListOptionsProvider.Openai,
                _ => null,
            };
        }
    }
}