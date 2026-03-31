//HintName: G.Models.PartialTalkAgentPresenterVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum PartialTalkAgentPresenterVoiceElevenLabsAccess
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
    public static class PartialTalkAgentPresenterVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialTalkAgentPresenterVoiceElevenLabsAccess value)
        {
            return value switch
            {
                PartialTalkAgentPresenterVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                PartialTalkAgentPresenterVoiceElevenLabsAccess.Premium => "premium",
                PartialTalkAgentPresenterVoiceElevenLabsAccess.Private => "private",
                PartialTalkAgentPresenterVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialTalkAgentPresenterVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => PartialTalkAgentPresenterVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => PartialTalkAgentPresenterVoiceElevenLabsAccess.Premium,
                "private" => PartialTalkAgentPresenterVoiceElevenLabsAccess.Private,
                "public" => PartialTalkAgentPresenterVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}