//HintName: G.Models.StructuredResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredResult
    {
        /// <summary>
        /// List of structured pages or failed page entries
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.StructuredResultPage, global::G.FailedStructuredPage>> Pages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredResult" /> class.
        /// </summary>
        /// <param name="pages">
        /// List of structured pages or failed page entries
        /// </param>
        public StructuredResult(
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.StructuredResultPage, global::G.FailedStructuredPage>> pages)
        {
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredResult" /> class.
        /// </summary>
        public StructuredResult()
        {
        }
    }
}