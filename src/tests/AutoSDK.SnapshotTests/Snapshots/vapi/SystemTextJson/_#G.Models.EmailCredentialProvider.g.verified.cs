//HintName: G.Models.EmailCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmailCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Email,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmailCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailCredentialProvider value)
        {
            return value switch
            {
                EmailCredentialProvider.Email => "email",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "email" => EmailCredentialProvider.Email,
                _ => null,
            };
        }
    }
}