//HintName: G.Models.LlamaParseTablesOutputTablesAsMarkdown.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output tables as markdown pipe tables instead of HTML &lt;table&gt; tags. Markdown tables are simpler but cannot represent complex structures like merged cells
    /// </summary>
    public sealed partial class LlamaParseTablesOutputTablesAsMarkdown
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}