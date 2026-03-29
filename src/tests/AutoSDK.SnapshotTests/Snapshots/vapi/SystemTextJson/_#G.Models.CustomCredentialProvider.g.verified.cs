//HintName: G.Models.CustomCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        CustomCredential,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomCredentialProvider value)
        {
            return value switch
            {
                CustomCredentialProvider.CustomCredential => "custom-credential",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-credential" => CustomCredentialProvider.CustomCredential,
                _ => null,
            };
        }
    }
}