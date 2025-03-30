//HintName: G.Models.TableExtractorSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specification for which table extractor to use. If not specified, the platform uses the default extractor.
    /// </summary>
    public sealed partial class TableExtractorSpec
    {
        /// <summary>
        /// The name of the table extractor to use.<br/>
        /// Example: textract
        /// </summary>
        /// <example>textract</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableExtractorSpec" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the table extractor to use.<br/>
        /// Example: textract
        /// </param>
        public TableExtractorSpec(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableExtractorSpec" /> class.
        /// </summary>
        public TableExtractorSpec()
        {
        }
    }
}