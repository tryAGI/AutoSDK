//HintName: G.Models.InteractionLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Limit interactions to a specific type of user for a specified duration
    /// </summary>
    public sealed partial class InteractionLimit
    {
        /// <summary>
        /// The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.
        /// <br/>Example: collaborators_only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.InteractionLimitLimitJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required InteractionLimitLimit Limit { get; set; }

        /// <summary>
        /// The duration of the interaction restriction. Default: `one_day`.
        /// <br/>Example: one_month
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiry")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.InteractionLimitExpiryJsonConverter))]
        public InteractionLimitExpiry? Expiry { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}