//HintName: G.Models.CreateRunpodCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateRunpodCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Runpod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRunpodCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRunpodCredentialDTOProvider value)
        {
            return value switch
            {
                CreateRunpodCredentialDTOProvider.Runpod => "runpod",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRunpodCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "runpod" => CreateRunpodCredentialDTOProvider.Runpod,
                _ => null,
            };
        }
    }
}