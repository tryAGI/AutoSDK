//HintName: G.Models.TranscriptOptionalParamsRedactPiiSub.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The replacement logic for detected PII, can be "entity_type" or "hash". See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.<br/>
    /// Default Value: hash
    /// </summary>
    public sealed partial class TranscriptOptionalParamsRedactPiiSub
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}