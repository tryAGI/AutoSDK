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
        [global::Newtonsoft.Json.JsonProperty("digest", Required = global::Newtonsoft.Json.Required.Always)]
        public string Digest { get; set; } = default!;

        /// <summary>
        /// The ID of the created op
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// The version index of the created op
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionIndex { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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