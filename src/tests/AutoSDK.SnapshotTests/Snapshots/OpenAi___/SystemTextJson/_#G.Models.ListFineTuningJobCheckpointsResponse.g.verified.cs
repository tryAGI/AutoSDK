//HintName: G.Models.ListFineTuningJobCheckpointsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListFineTuningJobCheckpointsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FineTuningJobCheckpoint> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ListFineTuningJobCheckpointsResponseObjectJsonConverter))]
        public global::G.ListFineTuningJobCheckpointsResponseObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFineTuningJobCheckpointsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="object"></param>
        /// <param name="firstId"></param>
        /// <param name="lastId"></param>
        /// <param name="hasMore"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListFineTuningJobCheckpointsResponse(
            global::System.Collections.Generic.IList<global::G.FineTuningJobCheckpoint> data,
            bool hasMore,
            global::G.ListFineTuningJobCheckpointsResponseObject @object,
            string? firstId,
            string? lastId)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.Object = @object;
            this.FirstId = firstId;
            this.LastId = lastId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFineTuningJobCheckpointsResponse" /> class.
        /// </summary>
        public ListFineTuningJobCheckpointsResponse()
        {
        }
    }
}