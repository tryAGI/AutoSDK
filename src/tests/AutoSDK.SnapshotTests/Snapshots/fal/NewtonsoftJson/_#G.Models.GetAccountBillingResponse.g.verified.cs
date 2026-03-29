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
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// Credit balance details. Only present when 'credits' is included in expand parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits")]
        public global::G.GetAccountBillingResponseCredits? Credits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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