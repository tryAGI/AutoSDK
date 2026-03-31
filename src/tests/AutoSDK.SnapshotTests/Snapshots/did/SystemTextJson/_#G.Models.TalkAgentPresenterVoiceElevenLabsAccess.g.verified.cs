//HintName: G.Models.TalkAgentPresenterVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum TalkAgentPresenterVoiceElevenLabsAccess
    {
        /// <summary>
        /// 
        /// </summary>
        ExternalPrivate,
        /// <summary>
        /// 
        /// </summary>
        Premium,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TalkAgentPresenterVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TalkAgentPresenterVoiceElevenLabsAccess value)
        {
            return value switch
            {
                TalkAgentPresenterVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                TalkAgentPresenterVoiceElevenLabsAccess.Premium => "premium",
                TalkAgentPresenterVoiceElevenLabsAccess.Private => "private",
                TalkAgentPresenterVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TalkAgentPresenterVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => TalkAgentPresenterVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => TalkAgentPresenterVoiceElevenLabsAccess.Premium,
                "private" => TalkAgentPresenterVoiceElevenLabsAccess.Private,
                "public" => TalkAgentPresenterVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}