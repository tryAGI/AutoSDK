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
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Remaining { get; set; }

        /// <summary>
        /// Credits that will expire in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiring")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Expiring { get; set; }

        /// <summary>
        /// Credits used in the current billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Used { get; set; }

        /// <summary>
        /// Credits for each workspace mapped by workspace_id. Only included if user is in a workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_credits")]
        public global::System.Collections.Generic.Dictionary<string, int>? WorkspaceCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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