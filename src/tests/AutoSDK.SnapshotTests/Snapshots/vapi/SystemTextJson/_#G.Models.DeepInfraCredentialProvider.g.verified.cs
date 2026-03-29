//HintName: G.Models.DeepInfraCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeepInfraCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Deepinfra,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepInfraCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepInfraCredentialProvider value)
        {
            return value switch
            {
                DeepInfraCredentialProvider.Deepinfra => "deepinfra",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepInfraCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "deepinfra" => DeepInfraCredentialProvider.Deepinfra,
                _ => null,
            };
        }
    }
}