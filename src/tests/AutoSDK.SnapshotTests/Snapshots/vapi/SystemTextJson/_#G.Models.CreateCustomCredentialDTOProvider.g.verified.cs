//HintName: G.Models.CreateCustomCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCustomCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        CustomCredential,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCustomCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCustomCredentialDTOProvider value)
        {
            return value switch
            {
                CreateCustomCredentialDTOProvider.CustomCredential => "custom-credential",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCustomCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-credential" => CreateCustomCredentialDTOProvider.CustomCredential,
                _ => null,
            };
        }
    }
}