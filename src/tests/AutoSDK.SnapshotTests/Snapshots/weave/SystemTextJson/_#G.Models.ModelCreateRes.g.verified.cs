//HintName: G.Models.ModelCreateRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelCreateRes
    {
        /// <summary>
        /// The digest of the created model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// The ID of the created model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectId { get; set; }

        /// <summary>
        /// The version index of the created model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionIndex { get; set; }

        /// <summary>
        /// Full reference to the created model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCreateRes" /> class.
        /// </summary>
        /// <param name="digest">
        /// The digest of the created model
        /// </param>
        /// <param name="objectId">
        /// The ID of the created model
        /// </param>
        /// <param name="versionIndex">
        /// The version index of the created model
        /// </param>
        /// <param name="modelRef">
        /// Full reference to the created model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelCreateRes(
            string digest,
            string objectId,
            int versionIndex,
            string modelRef)
        {
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.VersionIndex = versionIndex;
            this.ModelRef = modelRef ?? throw new global::System.ArgumentNullException(nameof(modelRef));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCreateRes" /> class.
        /// </summary>
        public ModelCreateRes()
        {
        }
    }
}