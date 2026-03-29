//HintName: G.Models.KlingEditElement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Element for character/subject consistency in Kling video generation.<br/>
    /// Reference as @Element1, @Element2, etc. in prompt.
    /// </summary>
    public sealed partial class KlingEditElement
    {
        /// <summary>
        /// ID of the frontal image asset for this element.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frontal_image_asset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FrontalImageAssetId { get; set; } = default!;

        /// <summary>
        /// Optional IDs of additional reference image assets (different angles).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_image_asset_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceImageAssetIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KlingEditElement" /> class.
        /// </summary>
        /// <param name="frontalImageAssetId">
        /// ID of the frontal image asset for this element.
        /// </param>
        /// <param name="referenceImageAssetIds">
        /// Optional IDs of additional reference image assets (different angles).
        /// </param>
        public KlingEditElement(
            global::System.Guid frontalImageAssetId,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceImageAssetIds)
        {
            this.FrontalImageAssetId = frontalImageAssetId;
            this.ReferenceImageAssetIds = referenceImageAssetIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KlingEditElement" /> class.
        /// </summary>
        public KlingEditElement()
        {
        }
    }
}