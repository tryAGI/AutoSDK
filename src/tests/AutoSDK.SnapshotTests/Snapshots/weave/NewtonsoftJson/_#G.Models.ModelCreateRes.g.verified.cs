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
        [global::Newtonsoft.Json.JsonProperty("digest", Required = global::Newtonsoft.Json.Required.Always)]
        public string Digest { get; set; } = default!;

        /// <summary>
        /// The ID of the created model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// The version index of the created model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionIndex { get; set; } = default!;

        /// <summary>
        /// Full reference to the created model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelRef { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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