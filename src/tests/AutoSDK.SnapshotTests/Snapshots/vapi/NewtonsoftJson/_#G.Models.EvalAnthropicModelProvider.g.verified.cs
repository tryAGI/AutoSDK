//HintName: G.Models.EvalAnthropicModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider of the model (`anthropic`).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalAnthropicModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic")]
        Anthropic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalAnthropicModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalAnthropicModelProvider value)
        {
            return value switch
            {
                EvalAnthropicModelProvider.Anthropic => "anthropic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalAnthropicModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => EvalAnthropicModelProvider.Anthropic,
                _ => null,
            };
        }
    }
}