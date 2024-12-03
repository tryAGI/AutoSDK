//HintName: G.Models.AddCreditsToAccountRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddCreditsToAccountRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid AccountId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits", Required = global::Newtonsoft.Json.Required.Always)]
        public double Credits { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reason { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCreditsToAccountRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="credits"></param>
        /// <param name="reason"></param>
        public AddCreditsToAccountRequest(
            global::System.Guid accountId,
            double credits,
            string reason)
        {
            this.AccountId = accountId;
            this.Credits = credits;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCreditsToAccountRequest" /> class.
        /// </summary>
        public AddCreditsToAccountRequest()
        {
        }
    }
}