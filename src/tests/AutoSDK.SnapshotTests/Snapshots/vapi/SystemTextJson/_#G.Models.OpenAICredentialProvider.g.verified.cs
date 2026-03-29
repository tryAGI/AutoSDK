//HintName: G.Models.OpenAICredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAICredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAICredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAICredentialProvider value)
        {
            return value switch
            {
                OpenAICredentialProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAICredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => OpenAICredentialProvider.Openai,
                _ => null,
            };
        }
    }
}