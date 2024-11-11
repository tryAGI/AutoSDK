//HintName: G.Models.ListModelRunsByRequesterResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListModelRunsByRequesterResponse is the request message for ListModelRunsByRequester.
    /// </summary>
    public sealed partial class ListModelRunsByRequesterResponse
    {
        /// <summary>
        /// A list of runs resources.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runs")]
        public global::System.Collections.Generic.IList<global::G.ModelRun>? Runs { get; set; }

        /// <summary>
        /// Total number of runs.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// The requested page size.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// The requested page offset.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelRunsByRequesterResponse" /> class.
        /// </summary>
        /// <param name="runs">
        /// A list of runs resources.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// Total number of runs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pageSize">
        /// The requested page size.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="page">
        /// The requested page offset.<br/>
        /// Included only in responses
        /// </param>
        public ListModelRunsByRequesterResponse(
            global::System.Collections.Generic.IList<global::G.ModelRun>? runs,
            int? totalSize,
            int? pageSize,
            int? page)
        {
            this.Runs = runs;
            this.TotalSize = totalSize;
            this.PageSize = pageSize;
            this.Page = page;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelRunsByRequesterResponse" /> class.
        /// </summary>
        public ListModelRunsByRequesterResponse()
        {
        }
    }
}