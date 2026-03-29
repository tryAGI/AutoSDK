//HintName: G.Models.LangfuseCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LangfuseCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Langfuse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LangfuseCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LangfuseCredentialProvider value)
        {
            return value switch
            {
                LangfuseCredentialProvider.Langfuse => "langfuse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LangfuseCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "langfuse" => LangfuseCredentialProvider.Langfuse,
                _ => null,
            };
        }
    }
}