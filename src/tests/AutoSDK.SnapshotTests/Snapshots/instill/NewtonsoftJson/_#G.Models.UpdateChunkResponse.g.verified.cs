//HintName: G.Models.UpdateChunkResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateChunkResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk")]
        public global::G.Chunk? Chunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChunkResponse" /> class.
        /// </summary>
        /// <param name="chunk"></param>
        public UpdateChunkResponse(
            global::G.Chunk? chunk)
        {
            this.Chunk = chunk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChunkResponse" /> class.
        /// </summary>
        public UpdateChunkResponse()
        {
        }
    }
}