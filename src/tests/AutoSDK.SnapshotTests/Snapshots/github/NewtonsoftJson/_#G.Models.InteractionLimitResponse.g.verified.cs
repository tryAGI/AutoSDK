//HintName: G.Models.InteractionLimitResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Interaction limit settings.
    /// </summary>
    public sealed partial class InteractionLimitResponse
    {
        /// <summary>
        /// The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.<br/>
        /// Example: collaborators_only
        /// </summary>
        /// <example>collaborators_only</example>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InteractionGroup Limit { get; set; } = default!;

        /// <summary>
        /// Example: repository
        /// </summary>
        /// <example>repository</example>
        [global::Newtonsoft.Json.JsonProperty("origin", Required = global::Newtonsoft.Json.Required.Always)]
        public string Origin { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionLimitResponse" /> class.
        /// </summary>
        /// <param name="limit">
        /// The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.<br/>
        /// Example: collaborators_only
        /// </param>
        /// <param name="origin">
        /// Example: repository
        /// </param>
        /// <param name="expiresAt"></param>
        public InteractionLimitResponse(
            global::G.InteractionGroup limit,
            string origin,
            global::System.DateTime expiresAt)
        {
            this.Limit = limit;
            this.Origin = origin ?? throw new global::System.ArgumentNullException(nameof(origin));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionLimitResponse" /> class.
        /// </summary>
        public InteractionLimitResponse()
        {
        }
    }
}