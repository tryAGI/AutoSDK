//HintName: G.Models.OrgFeatureFlags.g.cs

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
        PlaygroundRunnables,
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
                _ => null,
            };
        }
    }
}