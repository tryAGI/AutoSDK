//HintName: G.Models.InspectScopedJWTOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InspectScopedJWTOut
    {
        /// <summary>
        /// unix timestamp of when the token expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset ExpiresAt { get; set; }

        /// <summary>
        /// which models is the token limited to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// how much is the total spending limit set at creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spending_limit")]
        public double? SpendingLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InspectScopedJWTOut" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// unix timestamp of when the token expires
        /// </param>
        /// <param name="models">
        /// which models is the token limited to
        /// </param>
        /// <param name="spendingLimit">
        /// how much is the total spending limit set at creation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InspectScopedJWTOut(
            global::System.DateTimeOffset expiresAt,
            global::System.Collections.Generic.IList<string>? models,
            double? spendingLimit)
        {
            this.ExpiresAt = expiresAt;
            this.Models = models;
            this.SpendingLimit = spendingLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InspectScopedJWTOut" /> class.
        /// </summary>
        public InspectScopedJWTOut()
        {
        }
    }
}