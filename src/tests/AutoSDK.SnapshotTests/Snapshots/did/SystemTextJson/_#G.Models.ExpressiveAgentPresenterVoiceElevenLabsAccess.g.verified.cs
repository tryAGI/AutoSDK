//HintName: G.Models.ExpressiveAgentPresenterVoiceElevenLabsAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access level of the requested voice.<br/>
    /// Use `external-private` together with the `x-api-key-external` for your own ElevenLabs voices.
    /// </summary>
    public enum ExpressiveAgentPresenterVoiceElevenLabsAccess
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
    public static class ExpressiveAgentPresenterVoiceElevenLabsAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAgentPresenterVoiceElevenLabsAccess value)
        {
            return value switch
            {
                ExpressiveAgentPresenterVoiceElevenLabsAccess.ExternalPrivate => "external-private",
                ExpressiveAgentPresenterVoiceElevenLabsAccess.Premium => "premium",
                ExpressiveAgentPresenterVoiceElevenLabsAccess.Private => "private",
                ExpressiveAgentPresenterVoiceElevenLabsAccess.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAgentPresenterVoiceElevenLabsAccess? ToEnum(string value)
        {
            return value switch
            {
                "external-private" => ExpressiveAgentPresenterVoiceElevenLabsAccess.ExternalPrivate,
                "premium" => ExpressiveAgentPresenterVoiceElevenLabsAccess.Premium,
                "private" => ExpressiveAgentPresenterVoiceElevenLabsAccess.Private,
                "public" => ExpressiveAgentPresenterVoiceElevenLabsAccess.Public,
                _ => null,
            };
        }
    }
}