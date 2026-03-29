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
        [global::System.Text.Json.Serialization.JsonPropertyName("frontal_image_asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FrontalImageAssetId { get; set; }

        /// <summary>
        /// Optional IDs of additional reference image assets (different angles).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_asset_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceImageAssetIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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