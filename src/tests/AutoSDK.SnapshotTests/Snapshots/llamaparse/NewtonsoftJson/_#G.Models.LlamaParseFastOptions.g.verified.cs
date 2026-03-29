//HintName: G.Models.LlamaParseFastOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for fast tier parsing (rule-based, no AI).<br/>
    /// Fast tier uses deterministic algorithms for text extraction without AI enhancement.<br/>
    /// It's the fastest and most cost-effective option, best suited for simple documents<br/>
    /// with standard layouts. Currently has no configurable options but reserved for<br/>
    /// future expansion.
    /// </summary>
    public sealed partial class LlamaParseFastOptions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}