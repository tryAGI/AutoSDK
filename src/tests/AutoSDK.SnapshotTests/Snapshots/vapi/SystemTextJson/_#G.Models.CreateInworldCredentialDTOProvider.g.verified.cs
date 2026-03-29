//HintName: G.Models.CreateInworldCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateInworldCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Inworld,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateInworldCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateInworldCredentialDTOProvider value)
        {
            return value switch
            {
                CreateInworldCredentialDTOProvider.Inworld => "inworld",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateInworldCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "inworld" => CreateInworldCredentialDTOProvider.Inworld,
                _ => null,
            };
        }
    }
}