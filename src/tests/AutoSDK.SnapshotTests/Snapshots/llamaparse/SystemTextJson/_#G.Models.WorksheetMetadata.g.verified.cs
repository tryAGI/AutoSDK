//HintName: G.Models.WorksheetMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata about a worksheet in a spreadsheet
    /// </summary>
    public sealed partial class WorksheetMetadata
    {
        /// <summary>
        /// Name of the worksheet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SheetName { get; set; }

        /// <summary>
        /// Generated title for the worksheet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Generated description of the worksheet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorksheetMetadata" /> class.
        /// </summary>
        /// <param name="sheetName">
        /// Name of the worksheet
        /// </param>
        /// <param name="title">
        /// Generated title for the worksheet
        /// </param>
        /// <param name="description">
        /// Generated description of the worksheet
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorksheetMetadata(
            string sheetName,
            string? title,
            string? description)
        {
            this.SheetName = sheetName ?? throw new global::System.ArgumentNullException(nameof(sheetName));
            this.Title = title;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorksheetMetadata" /> class.
        /// </summary>
        public WorksheetMetadata()
        {
        }
    }
}