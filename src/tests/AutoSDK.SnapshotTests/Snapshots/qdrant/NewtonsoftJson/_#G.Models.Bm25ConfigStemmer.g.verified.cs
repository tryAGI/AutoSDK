//HintName: G.Models.Bm25ConfigStemmer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration of the stemmer. Processes tokens to their root form. Default: initialized Snowball stemmer for specified `language` or English if not specified.
    /// </summary>
    public sealed partial class Bm25ConfigStemmer
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}