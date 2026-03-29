//HintName: G.Models.ElevenLabsCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ElevenLabsCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="11labs")]
        x11labs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElevenLabsCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsCredentialProvider value)
        {
            return value switch
            {
                ElevenLabsCredentialProvider.x11labs => "11labs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => ElevenLabsCredentialProvider.x11labs,
                _ => null,
            };
        }
    }
}