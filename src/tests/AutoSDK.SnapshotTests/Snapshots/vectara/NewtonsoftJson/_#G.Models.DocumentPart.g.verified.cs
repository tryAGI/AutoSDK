//HintName: G.Models.DocumentPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A part of a document. This section gets converted into an embedding and directly maps to a search result. Usually a sentence.
    /// </summary>
    public sealed partial class DocumentPart
    {
        /// <summary>
        /// The text of the document part.<br/>
        /// Example: This invoice includes customer billing history for Q1.
        /// </summary>
        /// <example>This invoice includes customer billing history for Q1.</example>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The metadata for a document part. These may be used in metadata filters at query time if filter attributes are configured on the corpus.<br/>
        /// Example: {"part.rank":9000}
        /// </summary>
        /// <example>{"part.rank":9000}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The ID of the table that this document part is summarizing.<br/>
        /// Example: billing_table_111
        /// </summary>
        /// <example>billing_table_111</example>
        [global::Newtonsoft.Json.JsonProperty("table_id")]
        public string? TableId { get; set; }

        /// <summary>
        /// The ID of the image that this document part is summarizing.<br/>
        /// Example: image_1
        /// </summary>
        /// <example>image_1</example>
        [global::Newtonsoft.Json.JsonProperty("image_id")]
        public string? ImageId { get; set; }

        /// <summary>
        /// The context text for the document part.<br/>
        /// Example: Description of line items in the document part to provide additional context.
        /// </summary>
        /// <example>Description of line items in the document part to provide additional context.</example>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public string? Context { get; set; }

        /// <summary>
        /// The custom dimensions as additional weights.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_dimensions")]
        public global::System.Collections.Generic.Dictionary<string, double>? CustomDimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentPart" /> class.
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
        /// Example: Description of line items in the document part to provide additional context.
        /// </param>
        /// <param name="customDimensions">
        /// The custom dimensions as additional weights.
        /// </param>
        public DocumentPart(
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
        /// Initializes a new instance of the <see cref="DocumentPart" /> class.
        /// </summary>
        public DocumentPart()
        {
        }
    }
}