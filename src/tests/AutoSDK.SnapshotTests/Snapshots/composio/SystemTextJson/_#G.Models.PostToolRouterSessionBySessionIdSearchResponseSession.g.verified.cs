//HintName: G.Models.PostToolRouterSessionBySessionIdSearchResponseSession.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Session info for correlating meta tool calls
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchResponseSession
    {
        /// <summary>
        /// Session identifier to be passed to subsequent meta tool calls as session_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether a fresh session id was generated in this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool GenerateId { get; set; }

        /// <summary>
        /// LLM-facing guidance on how to reuse this session id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseSession" /> class.
        /// </summary>
        /// <param name="id">
        /// Session identifier to be passed to subsequent meta tool calls as session_id.
        /// </param>
        /// <param name="generateId">
        /// Whether a fresh session id was generated in this call.
        /// </param>
        /// <param name="instructions">
        /// LLM-facing guidance on how to reuse this session id
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdSearchResponseSession(
            string id,
            bool generateId,
            string instructions)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.GenerateId = generateId;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseSession" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchResponseSession()
        {
        }
    }
}