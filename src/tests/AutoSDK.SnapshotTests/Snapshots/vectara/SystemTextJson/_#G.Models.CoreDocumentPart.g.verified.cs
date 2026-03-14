//HintName: G.Models.CoreDocumentPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A part of a document. This section gets converted into an embedding and directly maps to a search result. Usually this is a sentence.
    /// </summary>
    public sealed partial class CoreDocumentPart
    {
        /// <summary>
        /// The text of the document part.<br/>
        /// Example: This invoice includes customer billing history for Q1.
        /// </summary>
        /// <example>This invoice includes customer billing history for Q1.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The metadata for a document part. These may be used in metadata filters at query time if filter attributes are configured on the corpus.<br/>
        /// Example: {"part.rank":9000}
        /// </summary>
        /// <example>{"part.rank":9000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The ID of the table that this document part is summarizing.<br/>
        /// Example: billing_table_111
        /// </summary>
        /// <example>billing_table_111</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_id")]
        public string? TableId { get; set; }

        /// <summary>
        /// The ID of the image that this document part is summarizing.<br/>
        /// Example: image_1
        /// </summary>
        /// <example>image_1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_id")]
        public string? ImageId { get; set; }

        /// <summary>
        /// The context text for the document part.<br/>
        /// Example: This document part is part of the table Customer Billing Info.
        /// </summary>
        /// <example>This document part is part of the table Customer Billing Info.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// The custom dimensions as additional weights.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_dimensions")]
        public global::System.Collections.Generic.Dictionary<string, double>? CustomDimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreDocumentPart" /> class.
        /// </summary>
        /// <param name="text">
        /// The text of the document part.<br/>
        /// Example: This invoice includes customer billing history for Q1.
        /// </param>
        /// <param name="metadata">
        /// The metadata for a document part. These may be used in metadata filters at query time if filter attributes are configured on the corpus.<br/>
        /// Example: {"part.rank":9000}
        /// </param>
        /// <param name="tableId">
        /// The ID of the table that this document part is summarizing.<br/>
        /// Example: billing_table_111
        /// </param>
        /// <param name="imageId">
        /// The ID of the image that this document part is summarizing.<br/>
        /// Example: image_1
        /// </param>
        /// <param name="context">
        /// The context text for the document part.<br/>
        /// Example: This document part is part of the table Customer Billing Info.
        /// </param>
        /// <param name="customDimensions">
        /// The custom dimensions as additional weights.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoreDocumentPart(
            string text,
            object? metadata,
            string? tableId,
            string? imageId,
            string? context,
            global::System.Collections.Generic.Dictionary<string, double>? customDimensions)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Metadata = metadata;
            this.TableId = tableId;
            this.ImageId = imageId;
            this.Context = context;
            this.CustomDimensions = customDimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreDocumentPart" /> class.
        /// </summary>
        public CoreDocumentPart()
        {
        }
    }
}