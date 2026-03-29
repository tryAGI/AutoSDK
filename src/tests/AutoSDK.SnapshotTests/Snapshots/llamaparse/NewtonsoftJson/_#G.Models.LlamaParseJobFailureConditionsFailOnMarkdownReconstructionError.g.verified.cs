//HintName: G.Models.LlamaParseJobFailureConditionsFailOnMarkdownReconstructionError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fail the entire job if markdown cannot be reconstructed for any page. By default, failed pages use fallback text extraction
    /// </summary>
    public sealed partial class LlamaParseJobFailureConditionsFailOnMarkdownReconstructionError
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}