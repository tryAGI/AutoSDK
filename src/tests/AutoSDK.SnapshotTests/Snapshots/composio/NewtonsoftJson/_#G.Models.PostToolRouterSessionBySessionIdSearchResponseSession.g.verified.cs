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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Whether a fresh session id was generated in this call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generate_id", Required = global::Newtonsoft.Json.Required.Always)]
        public bool GenerateId { get; set; } = default!;

        /// <summary>
        /// LLM-facing guidance on how to reuse this session id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public string Instructions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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