//HintName: G.Models.InputJsonBlockDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A delta in a streaming input JSON.
    /// </summary>
    public sealed partial class InputJsonBlockDelta
    {
        /// <summary>
        /// The partial JSON delta.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partial_json")]
        public string? PartialJson { get; set; }

        /// <summary>
        /// The type of content block.<br/>
        /// Default Value: input_json_delta
        /// </summary>
        /// <default>"input_json_delta"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputJsonBlockDelta" /> class.
        /// </summary>
        /// <param name="partialJson">
        /// The partial JSON delta.
        /// </param>
        /// <param name="type">
        /// The type of content block.<br/>
        /// Default Value: input_json_delta
        /// </param>
        public InputJsonBlockDelta(
            string type,
            string? partialJson)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.PartialJson = partialJson;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputJsonBlockDelta" /> class.
        /// </summary>
        public InputJsonBlockDelta()
        {
        }
    }
}