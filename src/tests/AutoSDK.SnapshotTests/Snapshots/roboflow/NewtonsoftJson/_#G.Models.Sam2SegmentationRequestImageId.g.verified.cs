//HintName: G.Models.Sam2SegmentationRequestImageId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The ID of the image to be segmented used to retrieve cached embeddings. If an embedding is cached, it will be used instead of generating a new embedding. If no embedding is cached, a new embedding will be generated and cached.
    /// </summary>
    public sealed partial class Sam2SegmentationRequestImageId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}