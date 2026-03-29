//HintName: G.Models.Bm25ConfigStopwords.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration of the stopwords filter. Supports list of pre-defined languages and custom stopwords. Default: initialized for specified `language` or English if not specified.
    /// </summary>
    public sealed partial class Bm25ConfigStopwords
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}