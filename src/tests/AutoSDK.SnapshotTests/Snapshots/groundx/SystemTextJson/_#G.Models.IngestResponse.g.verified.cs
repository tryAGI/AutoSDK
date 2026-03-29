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
        [global::System.Text.Json.Serialization.JsonPropertyName("ingest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.IngestResponseIngest Ingest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestResponse" /> class.
        /// </summary>
        /// <param name="ingest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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