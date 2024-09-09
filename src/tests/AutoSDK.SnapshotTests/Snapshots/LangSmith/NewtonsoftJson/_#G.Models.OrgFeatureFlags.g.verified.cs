//HintName: G.Models.OrgFeatureFlags.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Feature flags for orgs (cannot subclass an enum and may diverge from tenant flags, so maintained separately).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgFeatureFlags
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="playground_runnables")]
        PlaygroundRunnables,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hosted_langserve_enabled")]
        HostedLangserveEnabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="payment_enabled")]
        PaymentEnabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="run_rules_enabled")]
        RunRulesEnabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation_view_enabled")]
        ConversationViewEnabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="usage_reporting_enabled")]
        UsageReportingEnabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="show_upgrade_billing_ui")]
        ShowUpgradeBillingUi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rbac_enabled")]
        RbacEnabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pat_enabled")]
        PatEnabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="show_ttl_ui")]
        ShowTtlUi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="allow_backfill_rules")]
        AllowBackfillRules,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="playground_comparative")]
        PlaygroundComparative,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="show_dataset_schemas")]
        ShowDatasetSchemas,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="compare_trace_enabled")]
        CompareTraceEnabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="consolidate_playground_comparative")]
        ConsolidatePlaygroundComparative,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resource_tags")]
        ResourceTags,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="langgraph_deploy_own_cloud_enabled")]
        LanggraphDeployOwnCloudEnabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgFeatureFlagsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgFeatureFlags value)
        {
            return value switch
            {
                OrgFeatureFlags.PlaygroundRunnables => "playground_runnables",
                OrgFeatureFlags.HostedLangserveEnabled => "hosted_langserve_enabled",
                OrgFeatureFlags.PaymentEnabled => "payment_enabled",
                OrgFeatureFlags.RunRulesEnabled => "run_rules_enabled",
                OrgFeatureFlags.ConversationViewEnabled => "conversation_view_enabled",
                OrgFeatureFlags.UsageReportingEnabled => "usage_reporting_enabled",
                OrgFeatureFlags.ShowUpgradeBillingUi => "show_upgrade_billing_ui",
                OrgFeatureFlags.RbacEnabled => "rbac_enabled",
                OrgFeatureFlags.PatEnabled => "pat_enabled",
                OrgFeatureFlags.ShowTtlUi => "show_ttl_ui",
                OrgFeatureFlags.AllowBackfillRules => "allow_backfill_rules",
                OrgFeatureFlags.PlaygroundComparative => "playground_comparative",
                OrgFeatureFlags.ShowDatasetSchemas => "show_dataset_schemas",
                OrgFeatureFlags.CompareTraceEnabled => "compare_trace_enabled",
                OrgFeatureFlags.ConsolidatePlaygroundComparative => "consolidate_playground_comparative",
                OrgFeatureFlags.ResourceTags => "resource_tags",
                OrgFeatureFlags.LanggraphDeployOwnCloudEnabled => "langgraph_deploy_own_cloud_enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgFeatureFlags? ToEnum(string value)
        {
            return value switch
            {
                "playground_runnables" => OrgFeatureFlags.PlaygroundRunnables,
                "hosted_langserve_enabled" => OrgFeatureFlags.HostedLangserveEnabled,
                "payment_enabled" => OrgFeatureFlags.PaymentEnabled,
                "run_rules_enabled" => OrgFeatureFlags.RunRulesEnabled,
                "conversation_view_enabled" => OrgFeatureFlags.ConversationViewEnabled,
                "usage_reporting_enabled" => OrgFeatureFlags.UsageReportingEnabled,
                "show_upgrade_billing_ui" => OrgFeatureFlags.ShowUpgradeBillingUi,
                "rbac_enabled" => OrgFeatureFlags.RbacEnabled,
                "pat_enabled" => OrgFeatureFlags.PatEnabled,
                "show_ttl_ui" => OrgFeatureFlags.ShowTtlUi,
                "allow_backfill_rules" => OrgFeatureFlags.AllowBackfillRules,
                "playground_comparative" => OrgFeatureFlags.PlaygroundComparative,
                "show_dataset_schemas" => OrgFeatureFlags.ShowDatasetSchemas,
                "compare_trace_enabled" => OrgFeatureFlags.CompareTraceEnabled,
                "consolidate_playground_comparative" => OrgFeatureFlags.ConsolidatePlaygroundComparative,
                "resource_tags" => OrgFeatureFlags.ResourceTags,
                "langgraph_deploy_own_cloud_enabled" => OrgFeatureFlags.LanggraphDeployOwnCloudEnabled,
                _ => null,
            };
        }
    }
}