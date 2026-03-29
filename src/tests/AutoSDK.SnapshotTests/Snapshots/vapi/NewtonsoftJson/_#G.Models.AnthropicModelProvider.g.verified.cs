//HintName: G.Models.AnthropicModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider identifier for Anthropic.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnthropicModelProvider
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
    public static class AnthropicModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicModelProvider value)
        {
            return value switch
            {
                AnthropicModelProvider.Anthropic => "anthropic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => AnthropicModelProvider.Anthropic,
                _ => null,
            };
        }
    }
}