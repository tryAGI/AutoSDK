//HintName: G.Models.PromotionalEventForListPromotionalEventImageRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromotionalEventForListPromotionalEventImageRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageName")]
        public string? ImageName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDateUtc")]
        public global::System.DateTime? CreatedDateUtc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[]? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagePlacementOptionEnumId")]
        public int? ImagePlacementOptionEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageHyperlink")]
        public string? ImageHyperlink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionalEventForListPromotionalEventImageRequestDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="imageName"></param>
        /// <param name="createdDateUtc"></param>
        /// <param name="data"></param>
        /// <param name="imagePlacementOptionEnumId"></param>
        /// <param name="imageHyperlink"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromotionalEventForListPromotionalEventImageRequestDto(
            long? id,
            string? imageName,
            global::System.DateTime? createdDateUtc,
            byte[]? data,
            int? imagePlacementOptionEnumId,
            string? imageHyperlink)
        {
            this.Id = id;
            this.ImageName = imageName;
            this.CreatedDateUtc = createdDateUtc;
            this.Data = data;
            this.ImagePlacementOptionEnumId = imagePlacementOptionEnumId;
            this.ImageHyperlink = imageHyperlink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionalEventForListPromotionalEventImageRequestDto" /> class.
        /// </summary>
        public PromotionalEventForListPromotionalEventImageRequestDto()
        {
        }
    }
}