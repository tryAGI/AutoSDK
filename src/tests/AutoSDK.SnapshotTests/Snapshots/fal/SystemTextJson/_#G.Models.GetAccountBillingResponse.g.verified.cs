//HintName: G.Models.GetAccountBillingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Account billing information with optional expanded details
    /// </summary>
    public sealed partial class GetAccountBillingResponse
    {
        /// <summary>
        /// Account username<br/>
        /// Example: my-team
        /// </summary>
        /// <example>my-team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Credit balance details. Only present when 'credits' is included in expand parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public global::G.GetAccountBillingResponseCredits? Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountBillingResponse" /> class.
        /// </summary>
        /// <param name="username">
        /// Account username<br/>
        /// Example: my-team
        /// </param>
        /// <param name="credits">
        /// Credit balance details. Only present when 'credits' is included in expand parameter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAccountBillingResponse(
            string username,
            global::G.GetAccountBillingResponseCredits? credits)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Credits = credits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountBillingResponse" /> class.
        /// </summary>
        public GetAccountBillingResponse()
        {
        }
    }
}