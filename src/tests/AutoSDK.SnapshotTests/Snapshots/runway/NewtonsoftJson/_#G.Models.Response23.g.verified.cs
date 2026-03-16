//HintName: G.Models.Response23.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response23
    {
        /// <summary>
        /// Limits associated with the organization's tier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseTier Tier { get; set; } = default!;

        /// <summary>
        /// The number of credits remaining in the organization account.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creditBalance", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreditBalance { get; set; } = default!;

        /// <summary>
        /// Usage data for the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseUsage Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response23" /> class.
        /// </summary>
        /// <param name="tier">
        /// Limits associated with the organization's tier.
        /// </param>
        /// <param name="creditBalance">
        /// The number of credits remaining in the organization account.
        /// </param>
        /// <param name="usage">
        /// Usage data for the organization.
        /// </param>
        public Response23(
            global::G.ResponseTier tier,
            int creditBalance,
            global::G.ResponseUsage usage)
        {
            this.Tier = tier ?? throw new global::System.ArgumentNullException(nameof(tier));
            this.CreditBalance = creditBalance;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response23" /> class.
        /// </summary>
        public Response23()
        {
        }
    }
}