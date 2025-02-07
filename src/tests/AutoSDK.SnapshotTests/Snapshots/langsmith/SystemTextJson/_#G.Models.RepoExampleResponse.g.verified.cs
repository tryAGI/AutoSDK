//HintName: G.Models.RepoExampleResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for example runs
    /// </summary>
    public sealed partial class RepoExampleResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public object? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoExampleResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="startTime"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="sessionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepoExampleResponse(
            global::System.Guid id,
            global::System.Guid sessionId,
            global::System.DateTime? startTime,
            object? inputs,
            object? outputs)
        {
            this.Id = id;
            this.SessionId = sessionId;
            this.StartTime = startTime;
            this.Inputs = inputs;
            this.Outputs = outputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoExampleResponse" /> class.
        /// </summary>
        public RepoExampleResponse()
        {
        }
    }
}