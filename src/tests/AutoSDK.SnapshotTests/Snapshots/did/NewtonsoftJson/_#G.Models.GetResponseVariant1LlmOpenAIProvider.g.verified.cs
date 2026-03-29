//HintName: G.Models.GetResponseVariant1LlmOpenAIProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetResponseVariant1LlmOpenAIProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai")]
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetResponseVariant1LlmOpenAIProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseVariant1LlmOpenAIProvider value)
        {
            return value switch
            {
                GetResponseVariant1LlmOpenAIProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseVariant1LlmOpenAIProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => GetResponseVariant1LlmOpenAIProvider.Openai,
                _ => null,
            };
        }
    }
}