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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The queries used to search for files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Queries { get; set; }

        /// <summary>
        /// The results of the file search tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.FileSearchToolCallResult>? Results { get; set; }

        /// <summary>
        /// The status of the file search tool call. One of `in_progress`, <br/>
        /// `searching`, `incomplete` or `failed`,
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FileSearchToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FileSearchToolCallStatus Status { get; set; }

        /// <summary>
        /// The type of the file search tool call. Always `file_search_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FileSearchToolCallTypeJsonConverter))]
        public global::G.FileSearchToolCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the file search tool call.
        /// </param>
        /// <param name="queries">
        /// The queries used to search for files.
        /// </param>
        /// <param name="results">
        /// The results of the file search tool call.
        /// </param>
        /// <param name="status">
        /// The status of the file search tool call. One of `in_progress`, <br/>
        /// `searching`, `incomplete` or `failed`,
        /// </param>
        /// <param name="type">
        /// The type of the file search tool call. Always `file_search_call`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSearchToolCall(
            string id,
            global::System.Collections.Generic.IList<string> queries,
            global::G.FileSearchToolCallStatus status,
            global::System.Collections.Generic.IList<global::G.FileSearchToolCallResult>? results,
            global::G.FileSearchToolCallType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Queries = queries ?? throw new global::System.ArgumentNullException(nameof(queries));
            this.Status = status;
            this.Results = results;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSearchToolCall" /> class.
        /// </summary>
        public FileSearchToolCall()
        {
        }
    }
}