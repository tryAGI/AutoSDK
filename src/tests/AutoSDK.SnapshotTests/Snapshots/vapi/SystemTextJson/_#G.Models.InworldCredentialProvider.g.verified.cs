//HintName: G.Models.InworldCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InworldCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Inworld,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InworldCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InworldCredentialProvider value)
        {
            return value switch
            {
                InworldCredentialProvider.Inworld => "inworld",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InworldCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "inworld" => InworldCredentialProvider.Inworld,
                _ => null,
            };
        }
    }
}