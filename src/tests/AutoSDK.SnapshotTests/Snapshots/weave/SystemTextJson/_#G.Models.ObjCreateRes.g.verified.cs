//HintName: G.Models.ObjCreateRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjCreateRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        public string? ObjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjCreateRes" /> class.
        /// </summary>
        /// <param name="digest"></param>
        /// <param name="objectId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObjCreateRes(
            string digest,
            string? objectId)
        {
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.ObjectId = objectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjCreateRes" /> class.
        /// </summary>
        public ObjCreateRes()
        {
        }
    }
}