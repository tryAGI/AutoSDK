﻿//HintName: G.Models.ListRunsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListRunsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RunSchema> Runs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cursors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string?> Cursors { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_cursors")]
        public global::System.Collections.Generic.Dictionary<string, object?>? SearchCursors { get; set; }

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
        /// Initializes a new instance of the <see cref="ListRunsResponse" /> class.
        /// </summary>
        /// <param name="runs"></param>
        /// <param name="cursors"></param>
        /// <param name="searchCursors"></param>
        /// <param name="parsedQuery"></param>
        public ListRunsResponse(
            global::System.Collections.Generic.IList<global::G.RunSchema> runs,
            global::System.Collections.Generic.Dictionary<string, string?> cursors,
            global::System.Collections.Generic.Dictionary<string, object?>? searchCursors,
            string? parsedQuery)
        {
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
            this.Cursors = cursors ?? throw new global::System.ArgumentNullException(nameof(cursors));
            this.SearchCursors = searchCursors;
            this.ParsedQuery = parsedQuery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRunsResponse" /> class.
        /// </summary>
        public ListRunsResponse()
        {
        }
    }
}