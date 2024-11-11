//HintName: G.Models.ListPublicDatasetRunsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListPublicDatasetRunsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RunPublicDatasetSchema> Runs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cursors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string?> Cursors { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parsed_query")]
        public string? ParsedQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPublicDatasetRunsResponse" /> class.
        /// </summary>
        /// <param name="runs"></param>
        /// <param name="cursors"></param>
        /// <param name="parsedQuery"></param>
        public ListPublicDatasetRunsResponse(
            global::System.Collections.Generic.IList<global::G.RunPublicDatasetSchema> runs,
            global::System.Collections.Generic.Dictionary<string, string?> cursors,
            string? parsedQuery)
        {
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
            this.Cursors = cursors ?? throw new global::System.ArgumentNullException(nameof(cursors));
            this.ParsedQuery = parsedQuery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPublicDatasetRunsResponse" /> class.
        /// </summary>
        public ListPublicDatasetRunsResponse()
        {
        }
    }
}