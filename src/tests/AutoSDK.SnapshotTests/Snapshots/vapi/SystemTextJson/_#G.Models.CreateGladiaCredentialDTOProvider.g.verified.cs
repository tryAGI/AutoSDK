//HintName: G.Models.CreateGladiaCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGladiaCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Gladia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGladiaCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGladiaCredentialDTOProvider value)
        {
            return value switch
            {
                CreateGladiaCredentialDTOProvider.Gladia => "gladia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGladiaCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "gladia" => CreateGladiaCredentialDTOProvider.Gladia,
                _ => null,
            };
        }
    }
}