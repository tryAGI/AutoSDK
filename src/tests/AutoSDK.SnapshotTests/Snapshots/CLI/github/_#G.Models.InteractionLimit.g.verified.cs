﻿//HintName: G.Models.InteractionLimit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Limit interactions to a specific type of user for a specified duration
    /// </summary>
    public sealed partial class InteractionLimit
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
        /// The duration of the interaction restriction. Default: `one_day`.<br/>
        /// Example: one_month
        /// </summary>
        /// <example>one_month</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiry")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InteractionExpiryJsonConverter))]
        public global::G.InteractionExpiry? Expiry { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionLimit" /> class.
        /// </summary>
        /// <param name="limit">
        /// The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.<br/>
        /// Example: collaborators_only
        /// </param>
        /// <param name="expiry">
        /// The duration of the interaction restriction. Default: `one_day`.<br/>
        /// Example: one_month
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InteractionLimit(
            global::G.InteractionGroup limit,
            global::G.InteractionExpiry? expiry)
        {
            this.Limit = limit;
            this.Expiry = expiry;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionLimit" /> class.
        /// </summary>
        public InteractionLimit()
        {
        }
    }
}