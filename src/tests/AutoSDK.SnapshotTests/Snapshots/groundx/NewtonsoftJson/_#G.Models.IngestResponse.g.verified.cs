//HintName: G.Models.IngestResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IngestResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ingest", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.IngestResponseIngest Ingest { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestResponse" /> class.
        /// </summary>
        /// <param name="ingest"></param>
        public IngestResponse(
            global::G.IngestResponseIngest ingest)
        {
            this.Ingest = ingest ?? throw new global::System.ArgumentNullException(nameof(ingest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestResponse" /> class.
        /// </summary>
        public IngestResponse()
        {
        }
    }
}