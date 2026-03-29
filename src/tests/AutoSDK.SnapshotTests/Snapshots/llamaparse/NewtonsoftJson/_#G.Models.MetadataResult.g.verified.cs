//HintName: G.Models.MetadataResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result containing metadata (page level and general) for the parsed document.
    /// </summary>
    public sealed partial class MetadataResult
    {
        /// <summary>
        /// List of page metadata entries
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MetadataResultPage> Pages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataResult" /> class.
        /// </summary>
        /// <param name="pages">
        /// List of page metadata entries
        /// </param>
        public MetadataResult(
            global::System.Collections.Generic.IList<global::G.MetadataResultPage> pages)
        {
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataResult" /> class.
        /// </summary>
        public MetadataResult()
        {
        }
    }
}