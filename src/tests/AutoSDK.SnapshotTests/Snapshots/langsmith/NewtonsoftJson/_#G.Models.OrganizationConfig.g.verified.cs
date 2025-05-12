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
        [global::Newtonsoft.Json.JsonProperty("max_identities")]
        public int? MaxIdentities { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_workspaces")]
        public int? MaxWorkspaces { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_rbac")]
        public bool? CanUseRbac { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_add_seats")]
        public bool? CanAddSeats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startup_plan_approval_date")]
        public string? StartupPlanApprovalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partner_plan_approval_date")]
        public string? PartnerPlanApprovalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("premier_plan_approval_date")]
        public string? PremierPlanApprovalDate { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_disable_public_sharing")]
        public bool? CanDisablePublicSharing { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_serve_datasets")]
        public bool? CanServeDatasets { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_langgraph_cloud")]
        public bool? CanUseLanggraphCloud { get; set; }

        /// <summary>
        /// Default Value: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_langgraph_cloud_deployments")]
        public int? MaxLanggraphCloudDeployments { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_free_langgraph_cloud_deployments")]
        public int? MaxFreeLanggraphCloudDeployments { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_saml_sso")]
        public bool? CanUseSamlSso { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("can_use_bulk_export")]
        public bool? CanUseBulkExport { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_python_playground_service")]
        public bool? UsePythonPlaygroundService { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_updated_sidenav")]
        public bool? ShowUpdatedSidenav { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_updated_resource_tags")]
        public bool? ShowUpdatedResourceTags { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kv_dataset_message_support")]
        public bool? KvDatasetMessageSupport { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("show_playground_prompt_canvas")]
        public bool? ShowPlaygroundPromptCanvas { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_custom_iframes")]
        public bool? AllowCustomIframes { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_langgraph_pricing")]
        public bool? EnableLanggraphPricing { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_thread_view_playground")]
        public bool? EnableThreadViewPlayground { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_org_usage_charts")]
        public bool? EnableOrgUsageCharts { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_select_all_traces")]
        public bool? EnableSelectAllTraces { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_exact_search_for_prompts")]
        public bool? UseExactSearchForPrompts { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("langgraph_deploy_own_cloud_enabled")]
        public bool? LanggraphDeployOwnCloudEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_optimization_jobs_enabled")]
        public bool? PromptOptimizationJobsEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_k8s_vanilla_platform")]
        public bool? EnableK8sVanillaPlatform { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("demo_lgp_new_graph_enabled")]
        public bool? DemoLgpNewGraphEnabled { get; set; }

        /// <summary>
        /// Default Value: 20
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datadog_rum_session_sample_rate")]
        public int? DatadogRumSessionSampleRate { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("langgraph_remote_reconciler_enabled")]
        public bool? LanggraphRemoteReconcilerEnabled { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("langsmith_alerts_poc_enabled")]
        public bool? LangsmithAlertsPocEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_skip_topk_facets")]
        public bool? TenantSkipTopkFacets { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lgp_templates_enabled")]
        public bool? LgpTemplatesEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("langsmith_alerts_legacy_poc_enabled")]
        public bool? LangsmithAlertsLegacyPocEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_prebuilt_dashboards")]
        public bool? EnablePrebuiltDashboards { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("langsmith_experimental_search_enabled")]
        public bool? LangsmithExperimentalSearchEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("langgraph_platform_ga_enabled")]
        public bool? LanggraphPlatformGaEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="canDisablePublicSharing">
        /// Default Value: false
        /// </param>
        /// <param name="canServeDatasets">
        /// Default Value: false
        /// </param>
        /// <param name="canUseLanggraphCloud">
        /// Default Value: false
        /// </param>
        /// <param name="maxLanggraphCloudDeployments">
        /// Default Value: 3
        /// </param>
        /// <param name="maxFreeLanggraphCloudDeployments">
        /// Default Value: 0
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
        /// <param name="showUpdatedSidenav">
        /// Default Value: false
        /// </param>
        /// <param name="showUpdatedResourceTags">
        /// Default Value: false
        /// </param>
        /// <param name="kvDatasetMessageSupport">
        /// Default Value: true
        /// </param>
        /// <param name="showPlaygroundPromptCanvas">
        /// Default Value: false
        /// </param>
        /// <param name="allowCustomIframes">
        /// Default Value: false
        /// </param>
        /// <param name="enableLanggraphPricing">
        /// Default Value: false
        /// </param>
        /// <param name="enableThreadViewPlayground">
        /// Default Value: false
        /// </param>
        /// <param name="enableOrgUsageCharts">
        /// Default Value: false
        /// </param>
        /// <param name="enableSelectAllTraces">
        /// Default Value: false
        /// </param>
        /// <param name="useExactSearchForPrompts">
        /// Default Value: false
        /// </param>
        /// <param name="langgraphDeployOwnCloudEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="promptOptimizationJobsEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="enableK8sVanillaPlatform">
        /// Default Value: false
        /// </param>
        /// <param name="demoLgpNewGraphEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="datadogRumSessionSampleRate">
        /// Default Value: 20
        /// </param>
        /// <param name="langgraphRemoteReconcilerEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="langsmithAlertsPocEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="tenantSkipTopkFacets">
        /// Default Value: false
        /// </param>
        /// <param name="lgpTemplatesEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="langsmithAlertsLegacyPocEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="enablePrebuiltDashboards">
        /// Default Value: false
        /// </param>
        /// <param name="langsmithExperimentalSearchEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="langgraphPlatformGaEnabled">
        /// Default Value: false
        /// </param>
        public OrganizationConfig(
            int? maxIdentities,
            int? maxWorkspaces,
            bool? canUseRbac,
            bool? canAddSeats,
            string? startupPlanApprovalDate,
            string? partnerPlanApprovalDate,
            string? premierPlanApprovalDate,
            bool? canDisablePublicSharing,
            bool? canServeDatasets,
            bool? canUseLanggraphCloud,
            int? maxLanggraphCloudDeployments,
            int? maxFreeLanggraphCloudDeployments,
            bool? canUseSamlSso,
            bool? canUseBulkExport,
            bool? usePythonPlaygroundService,
            bool? showUpdatedSidenav,
            bool? showUpdatedResourceTags,
            bool? kvDatasetMessageSupport,
            bool? showPlaygroundPromptCanvas,
            bool? allowCustomIframes,
            bool? enableLanggraphPricing,
            bool? enableThreadViewPlayground,
            bool? enableOrgUsageCharts,
            bool? enableSelectAllTraces,
            bool? useExactSearchForPrompts,
            bool? langgraphDeployOwnCloudEnabled,
            bool? promptOptimizationJobsEnabled,
            bool? enableK8sVanillaPlatform,
            bool? demoLgpNewGraphEnabled,
            int? datadogRumSessionSampleRate,
            bool? langgraphRemoteReconcilerEnabled,
            bool? langsmithAlertsPocEnabled,
            bool? tenantSkipTopkFacets,
            bool? lgpTemplatesEnabled,
            bool? langsmithAlertsLegacyPocEnabled,
            bool? enablePrebuiltDashboards,
            bool? langsmithExperimentalSearchEnabled,
            bool? langgraphPlatformGaEnabled)
        {
            this.MaxIdentities = maxIdentities;
            this.MaxWorkspaces = maxWorkspaces;
            this.CanUseRbac = canUseRbac;
            this.CanAddSeats = canAddSeats;
            this.StartupPlanApprovalDate = startupPlanApprovalDate;
            this.PartnerPlanApprovalDate = partnerPlanApprovalDate;
            this.PremierPlanApprovalDate = premierPlanApprovalDate;
            this.CanDisablePublicSharing = canDisablePublicSharing;
            this.CanServeDatasets = canServeDatasets;
            this.CanUseLanggraphCloud = canUseLanggraphCloud;
            this.MaxLanggraphCloudDeployments = maxLanggraphCloudDeployments;
            this.MaxFreeLanggraphCloudDeployments = maxFreeLanggraphCloudDeployments;
            this.CanUseSamlSso = canUseSamlSso;
            this.CanUseBulkExport = canUseBulkExport;
            this.UsePythonPlaygroundService = usePythonPlaygroundService;
            this.ShowUpdatedSidenav = showUpdatedSidenav;
            this.ShowUpdatedResourceTags = showUpdatedResourceTags;
            this.KvDatasetMessageSupport = kvDatasetMessageSupport;
            this.ShowPlaygroundPromptCanvas = showPlaygroundPromptCanvas;
            this.AllowCustomIframes = allowCustomIframes;
            this.EnableLanggraphPricing = enableLanggraphPricing;
            this.EnableThreadViewPlayground = enableThreadViewPlayground;
            this.EnableOrgUsageCharts = enableOrgUsageCharts;
            this.EnableSelectAllTraces = enableSelectAllTraces;
            this.UseExactSearchForPrompts = useExactSearchForPrompts;
            this.LanggraphDeployOwnCloudEnabled = langgraphDeployOwnCloudEnabled;
            this.PromptOptimizationJobsEnabled = promptOptimizationJobsEnabled;
            this.EnableK8sVanillaPlatform = enableK8sVanillaPlatform;
            this.DemoLgpNewGraphEnabled = demoLgpNewGraphEnabled;
            this.DatadogRumSessionSampleRate = datadogRumSessionSampleRate;
            this.LanggraphRemoteReconcilerEnabled = langgraphRemoteReconcilerEnabled;
            this.LangsmithAlertsPocEnabled = langsmithAlertsPocEnabled;
            this.TenantSkipTopkFacets = tenantSkipTopkFacets;
            this.LgpTemplatesEnabled = lgpTemplatesEnabled;
            this.LangsmithAlertsLegacyPocEnabled = langsmithAlertsLegacyPocEnabled;
            this.EnablePrebuiltDashboards = enablePrebuiltDashboards;
            this.LangsmithExperimentalSearchEnabled = langsmithExperimentalSearchEnabled;
            this.LanggraphPlatformGaEnabled = langgraphPlatformGaEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationConfig" /> class.
        /// </summary>
        public OrganizationConfig()
        {
        }
    }
}