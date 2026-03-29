//HintName: G.Models.OpCreateRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for creating an Op object.
    /// </summary>
    public sealed partial class OpCreateRes
    {
        /// <summary>
        /// The digest of the created op
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// The ID of the created op
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectId { get; set; }

        /// <summary>
        /// The version index of the created op
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpCreateRes" /> class.
        /// </summary>
        /// <param name="digest">
        /// The digest of the created op
        /// </param>
        /// <param name="objectId">
        /// The ID of the created op
        /// </param>
        /// <param name="versionIndex">
        /// The version index of the created op
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpCreateRes(
            string digest,
            string objectId,
            int versionIndex)
        {
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.VersionIndex = versionIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpCreateRes" /> class.
        /// </summary>
        public OpCreateRes()
        {
        }
    }
}