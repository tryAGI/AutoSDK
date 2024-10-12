//HintName: G.Models.OrganizationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Organization level configuration. May include any field that exists in tenant config and additional fields.
    /// </summary>
    public sealed partial class OrganizationConfig
    {
        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_identities")]
        public int? MaxIdentities { get; set; } = 5;

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_workspaces")]
        public int? MaxWorkspaces { get; set; } = 1;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_rbac")]
        public bool? CanUseRbac { get; set; } = false;

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_add_seats")]
        public bool? CanAddSeats { get; set; } = true;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startup_plan_approval_date")]
        public string? StartupPlanApprovalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partner_plan_approval_date")]
        public string? PartnerPlanApprovalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("premier_plan_approval_date")]
        public string? PremierPlanApprovalDate { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_serve_datasets")]
        public bool? CanServeDatasets { get; set; } = false;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_langgraph_cloud")]
        public bool? CanUseLanggraphCloud { get; set; } = false;

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_langgraph_cloud_deployments")]
        public int? MaxLanggraphCloudDeployments { get; set; } = 1;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_saml_sso")]
        public bool? CanUseSamlSso { get; set; } = false;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_bulk_export")]
        public bool? CanUseBulkExport { get; set; } = false;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_python_playground_service")]
        public bool? UsePythonPlaygroundService { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flags")]
        public global::System.Collections.Generic.Dictionary<string, bool>? Flags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}