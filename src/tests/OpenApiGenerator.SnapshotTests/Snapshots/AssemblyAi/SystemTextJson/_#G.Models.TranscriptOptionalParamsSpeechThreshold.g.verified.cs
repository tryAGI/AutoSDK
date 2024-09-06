//HintName: G.Models.TranscriptOptionalParamsSpeechThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reject audio files that contain less than this fraction of speech.<br/>
    /// Valid values are in the range [0, 1] inclusive.<br/>
    /// Default Value: 0
    /// </summary>
    public sealed partial class TranscriptOptionalParamsSpeechThreshold
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}