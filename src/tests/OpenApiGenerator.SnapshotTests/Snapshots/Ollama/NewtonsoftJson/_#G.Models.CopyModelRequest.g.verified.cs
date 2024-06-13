//HintName: G.Models.CopyModelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request class for copying a model.
    /// </summary>
    public sealed partial class CopyModelRequest
    {
        /// <summary>
        /// Name of the model to copy.<br/>
        /// Example: llama2:7b
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public string Source { get; set; } = default!;

        /// <summary>
        /// Name of the new model.<br/>
        /// Example: llama2-backup
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("destination", Required = global::Newtonsoft.Json.Required.Always)]
        public string Destination { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}