//HintName: G.Models.XAiCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the api key for Grok in XAi's console. Get it from here: https://console.x.ai
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum XAiCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xai")]
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class XAiCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this XAiCredentialProvider value)
        {
            return value switch
            {
                XAiCredentialProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static XAiCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "xai" => XAiCredentialProvider.Xai,
                _ => null,
            };
        }
    }
}