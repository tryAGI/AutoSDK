//HintName: G.Models.TextResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextResult
    {
        /// <summary>
        /// List of text pages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TextResultPage> Pages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResult" /> class.
        /// </summary>
        /// <param name="pages">
        /// List of text pages
        /// </param>
        public TextResult(
            global::System.Collections.Generic.IList<global::G.TextResultPage> pages)
        {
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResult" /> class.
        /// </summary>
        public TextResult()
        {
        }
    }
}