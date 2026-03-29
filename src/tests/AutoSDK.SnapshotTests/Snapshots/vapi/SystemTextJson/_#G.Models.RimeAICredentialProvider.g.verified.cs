//HintName: G.Models.RimeAICredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RimeAICredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        RimeAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RimeAICredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RimeAICredentialProvider value)
        {
            return value switch
            {
                RimeAICredentialProvider.RimeAi => "rime-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RimeAICredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "rime-ai" => RimeAICredentialProvider.RimeAi,
                _ => null,
            };
        }
    }
}