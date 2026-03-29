//HintName: G.Models.ClipAgentPresenterVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipAgentPresenterVoiceElevenLabsAccess
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
    public static class ClipAgentPresenterVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipAgentPresenterVoiceElevenLabsAccess value)
        {
            return value switch
            {
                ClipAgentPresenterVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                ClipAgentPresenterVoiceElevenLabsAccess.Premium => "premium",
                ClipAgentPresenterVoiceElevenLabsAccess.Private => "private",
                ClipAgentPresenterVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipAgentPresenterVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => ClipAgentPresenterVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => ClipAgentPresenterVoiceElevenLabsAccess.Premium,
                "private" => ClipAgentPresenterVoiceElevenLabsAccess.Private,
                "public" => ClipAgentPresenterVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}