//HintName: G.Models.CreateRequestLlmVariant1Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum CreateRequestLlmVariant1Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRequestLlmVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestLlmVariant1Provider value)
        {
            return value switch
            {
                CreateRequestLlmVariant1Provider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestLlmVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => CreateRequestLlmVariant1Provider.Openai,
                _ => null,
            };
        }
    }
}