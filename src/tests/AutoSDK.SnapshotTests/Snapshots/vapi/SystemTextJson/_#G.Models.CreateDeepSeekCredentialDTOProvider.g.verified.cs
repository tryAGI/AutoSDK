//HintName: G.Models.CreateDeepSeekCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDeepSeekCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        DeepSeek,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeepSeekCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeepSeekCredentialDTOProvider value)
        {
            return value switch
            {
                CreateDeepSeekCredentialDTOProvider.DeepSeek => "deep-seek",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeepSeekCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "deep-seek" => CreateDeepSeekCredentialDTOProvider.DeepSeek,
                _ => null,
            };
        }
    }
}