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
        public int? MaxIdentities { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_workspaces")]
        public int? MaxWorkspaces { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_rbac")]
        public bool? CanUseRbac { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_add_seats")]
        public bool? CanAddSeats { get; set; }

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
        public bool? CanServeDatasets { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_langgraph_cloud")]
        public bool? CanUseLanggraphCloud { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_langgraph_cloud_deployments")]
        public int? MaxLanggraphCloudDeployments { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_saml_sso")]
        public bool? CanUseSamlSso { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_bulk_export")]
        public bool? CanUseBulkExport { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_python_playground_service")]
        public bool? UsePythonPlaygroundService { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationConfig" /> class.
        /// </summary>
        /// <param name="maxIdentities">
        /// Default Value: 5
        /// </param>
        /// <param name="maxWorkspaces">
        /// Default Value: 1
        /// </param>
        /// <param name="canUseRbac">
        /// Default Value: false
        /// </param>
        /// <param name="canAddSeats">
        /// Default Value: true
        /// </param>
        /// <param name="startupPlanApprovalDate"></param>
        /// <param name="partnerPlanApprovalDate"></param>
        /// <param name="premierPlanApprovalDate"></param>
        /// <param name="canServeDatasets">
        /// Default Value: false
        /// </param>
        /// <param name="canUseLanggraphCloud">
        /// Default Value: false
        /// </param>
        /// <param name="maxLanggraphCloudDeployments">
        /// Default Value: 1
        /// </param>
        /// <param name="canUseSamlSso">
        /// Default Value: false
        /// </param>
        /// <param name="canUseBulkExport">
        /// Default Value: false
        /// </param>
        /// <param name="usePythonPlaygroundService">
        /// Default Value: false
        /// </param>
        /// <param name="flags"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrganizationConfig(
            int? maxIdentities,
            int? maxWorkspaces,
            bool? canUseRbac,
            bool? canAddSeats,
            string? startupPlanApprovalDate,
            string? partnerPlanApprovalDate,
            string? premierPlanApprovalDate,
            bool? canServeDatasets,
            bool? canUseLanggraphCloud,
            int? maxLanggraphCloudDeployments,
            bool? canUseSamlSso,
            bool? canUseBulkExport,
            bool? usePythonPlaygroundService,
            global::System.Collections.Generic.Dictionary<string, bool>? flags)
        {
            this.MaxIdentities = maxIdentities;
            this.MaxWorkspaces = maxWorkspaces;
            this.CanUseRbac = canUseRbac;
            this.CanAddSeats = canAddSeats;
            this.StartupPlanApprovalDate = startupPlanApprovalDate;
            this.PartnerPlanApprovalDate = partnerPlanApprovalDate;
            this.PremierPlanApprovalDate = premierPlanApprovalDate;
            this.CanServeDatasets = canServeDatasets;
            this.CanUseLanggraphCloud = canUseLanggraphCloud;
            this.MaxLanggraphCloudDeployments = maxLanggraphCloudDeployments;
            this.CanUseSamlSso = canUseSamlSso;
            this.CanUseBulkExport = canUseBulkExport;
            this.UsePythonPlaygroundService = usePythonPlaygroundService;
            this.Flags = flags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationConfig" /> class.
        /// </summary>
        public OrganizationConfig()
        {
        }
    }
}