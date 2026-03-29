//HintName: G.Models.Infobox.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Container for infobox/knowledge panel results.
    /// </summary>
    public sealed partial class Infobox
    {
        /// <summary>
        /// The type identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// List of infobox results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::System.Collections.Generic.IList<global::G.InfoboxResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Infobox" /> class.
        /// </summary>
        /// <param name="type">
        /// The type identifier.
        /// </param>
        /// <param name="results">
        /// List of infobox results.
        /// </param>
        public Infobox(
            string? type,
            global::System.Collections.Generic.IList<global::G.InfoboxResult>? results)
        {
            this.Type = type;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Infobox" /> class.
        /// </summary>
        public Infobox()
        {
        }
    }
}