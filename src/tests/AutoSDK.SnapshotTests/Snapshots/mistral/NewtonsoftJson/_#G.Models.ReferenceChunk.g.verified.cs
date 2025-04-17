//HintName: G.Models.ReferenceChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReferenceChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> ReferenceIds { get; set; } = default!;

        /// <summary>
        /// Default Value: reference
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ReferenceChunkType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceChunk" /> class.
        /// </summary>
        /// <param name="referenceIds"></param>
        /// <param name="type">
        /// Default Value: reference
        /// </param>
        public ReferenceChunk(
            global::System.Collections.Generic.IList<int> referenceIds,
            global::G.ReferenceChunkType? type)
        {
            this.ReferenceIds = referenceIds ?? throw new global::System.ArgumentNullException(nameof(referenceIds));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceChunk" /> class.
        /// </summary>
        public ReferenceChunk()
        {
        }
    }
}