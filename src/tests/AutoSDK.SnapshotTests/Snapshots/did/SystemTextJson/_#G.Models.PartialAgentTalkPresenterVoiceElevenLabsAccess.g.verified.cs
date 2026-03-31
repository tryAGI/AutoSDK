//HintName: G.Models.PartialAgentTalkPresenterVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum PartialAgentTalkPresenterVoiceElevenLabsAccess
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
    public static class PartialAgentTalkPresenterVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialAgentTalkPresenterVoiceElevenLabsAccess value)
        {
            return value switch
            {
                PartialAgentTalkPresenterVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                PartialAgentTalkPresenterVoiceElevenLabsAccess.Premium => "premium",
                PartialAgentTalkPresenterVoiceElevenLabsAccess.Private => "private",
                PartialAgentTalkPresenterVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialAgentTalkPresenterVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => PartialAgentTalkPresenterVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => PartialAgentTalkPresenterVoiceElevenLabsAccess.Premium,
                "private" => PartialAgentTalkPresenterVoiceElevenLabsAccess.Private,
                "public" => PartialAgentTalkPresenterVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}