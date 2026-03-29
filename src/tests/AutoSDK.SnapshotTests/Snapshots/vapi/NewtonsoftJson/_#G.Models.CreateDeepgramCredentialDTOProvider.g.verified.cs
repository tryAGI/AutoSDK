//HintName: G.Models.CreateDeepgramCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateDeepgramCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepgram")]
        Deepgram,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDeepgramCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDeepgramCredentialDTOProvider value)
        {
            return value switch
            {
                CreateDeepgramCredentialDTOProvider.Deepgram => "deepgram",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDeepgramCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "deepgram" => CreateDeepgramCredentialDTOProvider.Deepgram,
                _ => null,
            };
        }
    }
}