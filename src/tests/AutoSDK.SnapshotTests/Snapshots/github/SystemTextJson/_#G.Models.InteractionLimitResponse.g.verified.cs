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
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InteractionGroupJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.InteractionGroup Limit { get; set; }

        /// <summary>
        /// Example: repository
        /// </summary>
        /// <example>repository</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Origin { get; set; }

        /// <summary>
        /// Example: 2018-08-17T04:18:39Z
        /// </summary>
        /// <example>2018-08-17T04:18:39Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// <param name="expiresAt">
        /// Example: 2018-08-17T04:18:39Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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