//HintName: G.Models.OpenAITranscriberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the transcription provider that will be used.
    /// </summary>
    public enum OpenAITranscriberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAITranscriberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAITranscriberProvider value)
        {
            return value switch
            {
                OpenAITranscriberProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAITranscriberProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => OpenAITranscriberProvider.Openai,
                _ => null,
            };
        }
    }
}