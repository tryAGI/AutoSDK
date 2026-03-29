//HintName: G.Models.CreateEmailCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateEmailCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Email,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEmailCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEmailCredentialDTOProvider value)
        {
            return value switch
            {
                CreateEmailCredentialDTOProvider.Email => "email",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEmailCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "email" => CreateEmailCredentialDTOProvider.Email,
                _ => null,
            };
        }
    }
}