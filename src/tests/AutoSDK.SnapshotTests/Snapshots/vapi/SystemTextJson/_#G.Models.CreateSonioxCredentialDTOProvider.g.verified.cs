//HintName: G.Models.CreateSonioxCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSonioxCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Soniox,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSonioxCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSonioxCredentialDTOProvider value)
        {
            return value switch
            {
                CreateSonioxCredentialDTOProvider.Soniox => "soniox",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSonioxCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "soniox" => CreateSonioxCredentialDTOProvider.Soniox,
                _ => null,
            };
        }
    }
}