//HintName: G.Models.PartialClipAgentPresenterVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum PartialClipAgentPresenterVoiceElevenLabsAccess
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
    public static class PartialClipAgentPresenterVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialClipAgentPresenterVoiceElevenLabsAccess value)
        {
            return value switch
            {
                PartialClipAgentPresenterVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                PartialClipAgentPresenterVoiceElevenLabsAccess.Premium => "premium",
                PartialClipAgentPresenterVoiceElevenLabsAccess.Private => "private",
                PartialClipAgentPresenterVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialClipAgentPresenterVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => PartialClipAgentPresenterVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => PartialClipAgentPresenterVoiceElevenLabsAccess.Premium,
                "private" => PartialClipAgentPresenterVoiceElevenLabsAccess.Private,
                "public" => PartialClipAgentPresenterVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}