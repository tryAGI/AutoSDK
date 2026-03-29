//HintName: G.Models.CreateVonageCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateVonageCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Vonage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVonageCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVonageCredentialDTOProvider value)
        {
            return value switch
            {
                CreateVonageCredentialDTOProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVonageCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "vonage" => CreateVonageCredentialDTOProvider.Vonage,
                _ => null,
            };
        }
    }
}