//HintName: G.Models.TableExtractor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A table extractor can be used to extract tabular data from documents during indexing.
    /// </summary>
    public sealed partial class TableExtractor
    {
        /// <summary>
        /// The name of the table extractor.<br/>
        /// Example: textract
        /// </summary>
        /// <example>textract</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Indicates whether it is the default extractor when not specified during indexing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// The description of the table extractor.<br/>
        /// Example: Uses the AWS Textract service to extract tables.
        /// </summary>
        /// <example>Uses the AWS Textract service to extract tables.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableExtractor" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the table extractor.<br/>
        /// Example: textract
        /// </param>
        /// <param name="isDefault">
        /// Indicates whether it is the default extractor when not specified during indexing.
        /// </param>
        /// <param name="description">
        /// The description of the table extractor.<br/>
        /// Example: Uses the AWS Textract service to extract tables.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableExtractor(
            string? name,
            bool? isDefault,
            string? description)
        {
            this.Name = name;
            this.IsDefault = isDefault;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableExtractor" /> class.
        /// </summary>
        public TableExtractor()
        {
        }
    }
}