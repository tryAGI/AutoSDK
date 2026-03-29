//HintName: G.Models.OpenAIModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider that will be used for the model.
    /// </summary>
    public enum OpenAIModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIModelProvider value)
        {
            return value switch
            {
                OpenAIModelProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => OpenAIModelProvider.Openai,
                _ => null,
            };
        }
    }
}