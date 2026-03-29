//HintName: G.Models.CreditBalance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the current balance of Credits and usage.
    /// </summary>
    public sealed partial class CreditBalance
    {
        /// <summary>
        /// Remaining credits not yet used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remaining", Required = global::Newtonsoft.Json.Required.Always)]
        public int Remaining { get; set; } = default!;

        /// <summary>
        /// Credits that will expire in the future.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiring", Required = global::Newtonsoft.Json.Required.Always)]
        public int Expiring { get; set; } = default!;

        /// <summary>
        /// Credits used in the current billing period.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("used", Required = global::Newtonsoft.Json.Required.Always)]
        public int Used { get; set; } = default!;

        /// <summary>
        /// Credits for each workspace mapped by workspace_id. Only included if user is in a workspace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_credits")]
        public global::System.Collections.Generic.Dictionary<string, int>? WorkspaceCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditBalance" /> class.
        /// </summary>
        /// <param name="remaining">
        /// Remaining credits not yet used.
        /// </param>
        /// <param name="expiring">
        /// Credits that will expire in the future.
        /// </param>
        /// <param name="used">
        /// Credits used in the current billing period.
        /// </param>
        /// <param name="workspaceCredits">
        /// Credits for each workspace mapped by workspace_id. Only included if user is in a workspace.
        /// </param>
        public CreditBalance(
            int remaining,
            int expiring,
            int used,
            global::System.Collections.Generic.Dictionary<string, int>? workspaceCredits)
        {
            this.Remaining = remaining;
            this.Expiring = expiring;
            this.Used = used;
            this.WorkspaceCredits = workspaceCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditBalance" /> class.
        /// </summary>
        public CreditBalance()
        {
        }
    }
}