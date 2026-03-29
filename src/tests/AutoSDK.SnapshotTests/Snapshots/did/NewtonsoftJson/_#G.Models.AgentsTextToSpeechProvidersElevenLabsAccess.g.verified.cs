//HintName: G.Models.AgentsTextToSpeechProvidersElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentsTextToSpeechProvidersElevenLabsAccess
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="external-private")]
        ExternalPrivate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="premium")]
        Premium,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsTextToSpeechProvidersElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsTextToSpeechProvidersElevenLabsAccess value)
        {
            return value switch
            {
                AgentsTextToSpeechProvidersElevenLabsAccess.ExternalPrivate => "external-private",
                AgentsTextToSpeechProvidersElevenLabsAccess.Premium => "premium",
                AgentsTextToSpeechProvidersElevenLabsAccess.Private => "private",
                AgentsTextToSpeechProvidersElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsTextToSpeechProvidersElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => AgentsTextToSpeechProvidersElevenLabsAccess.ExternalPrivate,
                "premium" => AgentsTextToSpeechProvidersElevenLabsAccess.Premium,
                "private" => AgentsTextToSpeechProvidersElevenLabsAccess.Private,
                "public" => AgentsTextToSpeechProvidersElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}