//HintName: G.Models.DeepSeekCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeepSeekCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deep-seek")]
        DeepSeek,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepSeekCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepSeekCredentialProvider value)
        {
            return value switch
            {
                DeepSeekCredentialProvider.DeepSeek => "deep-seek",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepSeekCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "deep-seek" => DeepSeekCredentialProvider.DeepSeek,
                _ => null,
            };
        }
    }
}