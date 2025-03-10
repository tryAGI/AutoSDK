﻿//HintName: G.Models.OrgFeatureFlags.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Feature flags for orgs (cannot subclass an enum and may diverge from tenant flags, so maintained separately).
    /// </summary>
    public enum OrgFeatureFlags
    {
        /// <summary>
        /// 
        /// </summary>
        HostedLangserveEnabled,
        /// <summary>
        /// 
        /// </summary>
        PaymentEnabled,
        /// <summary>
        /// 
        /// </summary>
        RunRulesEnabled,
        /// <summary>
        /// 
        /// </summary>
        ConversationViewEnabled,
        /// <summary>
        /// 
        /// </summary>
        UsageReportingEnabled,
        /// <summary>
        /// 
        /// </summary>
        ShowUpgradeBillingUi,
        /// <summary>
        /// 
        /// </summary>
        RbacEnabled,
        /// <summary>
        /// 
        /// </summary>
        PatEnabled,
        /// <summary>
        /// 
        /// </summary>
        ShowTtlUi,
        /// <summary>
        /// 
        /// </summary>
        AllowBackfillRules,
        /// <summary>
        /// 
        /// </summary>
        PlaygroundComparative,
        /// <summary>
        /// 
        /// </summary>
        ShowDatasetSchemas,
        /// <summary>
        /// 
        /// </summary>
        CompareTraceEnabled,
        /// <summary>
        /// 
        /// </summary>
        ResourceTags,
        /// <summary>
        /// 
        /// </summary>
        LanggraphDeployOwnCloudEnabled,
        /// <summary>
        /// 
        /// </summary>
        ArbitraryCodeExecutionEnabled,
        /// <summary>
        /// 
        /// </summary>
        PromptOptimization,
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
                OrgFeatureFlags.ResourceTags => "resource_tags",
                OrgFeatureFlags.LanggraphDeployOwnCloudEnabled => "langgraph_deploy_own_cloud_enabled",
                OrgFeatureFlags.ArbitraryCodeExecutionEnabled => "arbitrary_code_execution_enabled",
                OrgFeatureFlags.PromptOptimization => "prompt_optimization",
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
                "resource_tags" => OrgFeatureFlags.ResourceTags,
                "langgraph_deploy_own_cloud_enabled" => OrgFeatureFlags.LanggraphDeployOwnCloudEnabled,
                "arbitrary_code_execution_enabled" => OrgFeatureFlags.ArbitraryCodeExecutionEnabled,
                "prompt_optimization" => OrgFeatureFlags.PromptOptimization,
                _ => null,
            };
        }
    }
}