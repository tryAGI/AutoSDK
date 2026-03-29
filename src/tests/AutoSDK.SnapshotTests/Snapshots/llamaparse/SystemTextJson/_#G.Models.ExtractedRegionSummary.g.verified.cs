//HintName: G.Models.ExtractedRegionSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A summary of a single extracted region from a spreadsheet
    /// </summary>
    public sealed partial class ExtractedRegionSummary
    {
        /// <summary>
        /// Unique identifier for this region within the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_id")]
        public string? RegionId { get; set; }

        /// <summary>
        /// Worksheet name where region was found
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SheetName { get; set; }

        /// <summary>
        /// Location of the region in the spreadsheet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Location { get; set; }

        /// <summary>
        /// Type of the extracted region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RegionType { get; set; }

        /// <summary>
        /// Generated title for the region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Generated description for the region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractedRegionSummary" /> class.
        /// </summary>
        /// <param name="sheetName">
        /// Worksheet name where region was found
        /// </param>
        /// <param name="location">
        /// Location of the region in the spreadsheet
        /// </param>
        /// <param name="regionType">
        /// Type of the extracted region
        /// </param>
        /// <param name="regionId">
        /// Unique identifier for this region within the file
        /// </param>
        /// <param name="title">
        /// Generated title for the region
        /// </param>
        /// <param name="description">
        /// Generated description for the region
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractedRegionSummary(
            string sheetName,
            string location,
            string regionType,
            string? regionId,
            string? title,
            string? description)
        {
            this.RegionId = regionId;
            this.SheetName = sheetName ?? throw new global::System.ArgumentNullException(nameof(sheetName));
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
            this.RegionType = regionType ?? throw new global::System.ArgumentNullException(nameof(regionType));
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractedRegionSummary" /> class.
        /// </summary>
        public ExtractedRegionSummary()
        {
        }
    }
}