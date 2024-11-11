//HintName: G.Models.WebhooksAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The security alert of the vulnerable dependency.
    /// </summary>
    public sealed partial class WebhooksAlert
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("affected_package_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AffectedPackageName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("affected_range", Required = global::Newtonsoft.Json.Required.Always)]
        public string AffectedRange { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismiss_reason")]
        public string? DismissReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_at")]
        public string? DismissedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismisser")]
        public global::G.WebhooksAlertDismisser? Dismisser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_identifier", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExternalIdentifier { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_reference", Required = global::Newtonsoft.Json.Required.Always)]
        public string? ExternalReference { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fix_reason")]
        public string? FixReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fixed_at")]
        public global::System.DateTime? FixedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fixed_in")]
        public string? FixedIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ghsa_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string GhsaId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity", Required = global::Newtonsoft.Json.Required.Always)]
        public string Severity { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.WebhooksAlertState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksAlert" /> class.
        /// </summary>
        /// <param name="affectedPackageName"></param>
        /// <param name="affectedRange"></param>
        /// <param name="createdAt"></param>
        /// <param name="dismissReason"></param>
        /// <param name="dismissedAt"></param>
        /// <param name="dismisser"></param>
        /// <param name="externalIdentifier"></param>
        /// <param name="externalReference"></param>
        /// <param name="fixReason"></param>
        /// <param name="fixedAt"></param>
        /// <param name="fixedIn"></param>
        /// <param name="ghsaId"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="number"></param>
        /// <param name="severity"></param>
        /// <param name="state"></param>
        public WebhooksAlert(
            string affectedPackageName,
            string affectedRange,
            string createdAt,
            string externalIdentifier,
            string? externalReference,
            string ghsaId,
            int id,
            string nodeId,
            int number,
            string severity,
            string? dismissReason,
            string? dismissedAt,
            global::G.WebhooksAlertDismisser? dismisser,
            string? fixReason,
            global::System.DateTime? fixedAt,
            string? fixedIn,
            global::G.WebhooksAlertState state)
        {
            this.AffectedPackageName = affectedPackageName ?? throw new global::System.ArgumentNullException(nameof(affectedPackageName));
            this.AffectedRange = affectedRange ?? throw new global::System.ArgumentNullException(nameof(affectedRange));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ExternalIdentifier = externalIdentifier ?? throw new global::System.ArgumentNullException(nameof(externalIdentifier));
            this.ExternalReference = externalReference ?? throw new global::System.ArgumentNullException(nameof(externalReference));
            this.GhsaId = ghsaId ?? throw new global::System.ArgumentNullException(nameof(ghsaId));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Number = number;
            this.Severity = severity ?? throw new global::System.ArgumentNullException(nameof(severity));
            this.DismissReason = dismissReason;
            this.DismissedAt = dismissedAt;
            this.Dismisser = dismisser;
            this.FixReason = fixReason;
            this.FixedAt = fixedAt;
            this.FixedIn = fixedIn;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksAlert" /> class.
        /// </summary>
        public WebhooksAlert()
        {
        }
    }
}