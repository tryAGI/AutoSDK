//HintName: G.Models.CreateGroqCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGroqCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Groq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGroqCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGroqCredentialDTOProvider value)
        {
            return value switch
            {
                CreateGroqCredentialDTOProvider.Groq => "groq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGroqCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "groq" => CreateGroqCredentialDTOProvider.Groq,
                _ => null,
            };
        }
    }
}