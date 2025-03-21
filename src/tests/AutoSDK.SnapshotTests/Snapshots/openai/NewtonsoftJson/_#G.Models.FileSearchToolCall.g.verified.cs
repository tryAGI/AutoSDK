//HintName: G.Models.FileSearchToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The results of a file search tool call. See the <br/>
    /// [file search guide](/docs/guides/tools-file-search) for more information.
    /// </summary>
    public sealed partial class FileSearchToolCall
    {
        /// <summary>
        /// The unique ID of the file search tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of the file search tool call. Always `file_search_call`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FileSearchToolCallType Type { get; set; }

        /// <summary>
        /// The status of the file search tool call. One of `in_progress`, <br/>
        /// `searching`, `incomplete` or `failed`,
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FileSearchToolCallStatus Status { get; set; } = default!;

        /// <summary>
        /// The queries used to search for files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Queries { get; set; } = default!;

        /// <summary>
        /// The results of the file search tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::System.Collections.Generic.IList<global::G.FileSearchToolCallResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the file search tool call.
        /// </param>
        /// <param name="type">
        /// The type of the file search tool call. Always `file_search_call`.
        /// </param>
        /// <param name="status">
        /// The status of the file search tool call. One of `in_progress`, <br/>
        /// `searching`, `incomplete` or `failed`,
        /// </param>
        /// <param name="queries">
        /// The queries used to search for files.
        /// </param>
        /// <param name="results">
        /// The results of the file search tool call.
        /// </param>
        public FileSearchToolCall(
            string id,
            global::G.FileSearchToolCallStatus status,
            global::System.Collections.Generic.IList<string> queries,
            global::G.FileSearchToolCallType type,
            global::System.Collections.Generic.IList<global::G.FileSearchToolCallResult>? results)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Queries = queries ?? throw new global::System.ArgumentNullException(nameof(queries));
            this.Type = type;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchToolCall" /> class.
        /// </summary>
        public FileSearchToolCall()
        {
        }
    }
}