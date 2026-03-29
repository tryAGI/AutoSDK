//HintName: G.Models.CreateMakeCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateMakeCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Make,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMakeCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMakeCredentialDTOProvider value)
        {
            return value switch
            {
                CreateMakeCredentialDTOProvider.Make => "make",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMakeCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "make" => CreateMakeCredentialDTOProvider.Make,
                _ => null,
            };
        }
    }
}