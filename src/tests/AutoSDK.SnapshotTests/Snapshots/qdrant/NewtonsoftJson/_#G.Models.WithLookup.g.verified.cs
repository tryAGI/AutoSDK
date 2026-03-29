//HintName: G.Models.WithLookup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WithLookup
    {
        /// <summary>
        /// Name of the collection to use for points lookup
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collection", Required = global::Newtonsoft.Json.Required.Always)]
        public string Collection { get; set; } = default!;

        /// <summary>
        /// Options for specifying which payload to include (or not)<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("with_payload")]
        public global::G.WithPayloadInterface? WithPayload { get; set; }

        /// <summary>
        /// Options for specifying which vectors to include (or not)<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("with_vectors")]
        public global::G.WithVector? WithVectors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WithLookup" /> class.
        /// </summary>
        /// <param name="collection">
        /// Name of the collection to use for points lookup
        /// </param>
        /// <param name="withPayload">
        /// Options for specifying which payload to include (or not)<br/>
        /// Default Value: true
        /// </param>
        /// <param name="withVectors">
        /// Options for specifying which vectors to include (or not)<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public WithLookup(
            string collection,
            global::G.WithPayloadInterface? withPayload,
            global::G.WithVector? withVectors)
        {
            this.Collection = collection ?? throw new global::System.ArgumentNullException(nameof(collection));
            this.WithPayload = withPayload;
            this.WithVectors = withVectors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WithLookup" /> class.
        /// </summary>
        public WithLookup()
        {
        }
    }
}