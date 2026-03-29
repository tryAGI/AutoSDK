//HintName: G.Models.CreateTavusCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTavusCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Tavus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTavusCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTavusCredentialDTOProvider value)
        {
            return value switch
            {
                CreateTavusCredentialDTOProvider.Tavus => "tavus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTavusCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "tavus" => CreateTavusCredentialDTOProvider.Tavus,
                _ => null,
            };
        }
    }
}