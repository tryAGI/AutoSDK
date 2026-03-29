//HintName: G.Models.TemplatesSaveTemplateVersionRequestBlockReconciliationStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Strategy for reconciling memory blocks during migration: "reconcile-all" deletes blocks not in the template, "preserve-deleted" keeps them. Defaults to "preserve-deleted".
    /// </summary>
    public enum TemplatesSaveTemplateVersionRequestBlockReconciliationStrategy
    {
        /// <summary>
        /// "reconcile-all" deletes blocks not in the template, "preserve-deleted" keeps them. Defaults to "preserve-deleted".
        /// </summary>
        PreserveDeleted,
        /// <summary>
        /// "reconcile-all" deletes blocks not in the template, "preserve-deleted" keeps them. Defaults to "preserve-deleted".
        /// </summary>
        ReconcileAll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesSaveTemplateVersionRequestBlockReconciliationStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesSaveTemplateVersionRequestBlockReconciliationStrategy value)
        {
            return value switch
            {
                TemplatesSaveTemplateVersionRequestBlockReconciliationStrategy.PreserveDeleted => "preserve-deleted",
                TemplatesSaveTemplateVersionRequestBlockReconciliationStrategy.ReconcileAll => "reconcile-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesSaveTemplateVersionRequestBlockReconciliationStrategy? ToEnum(string value)
        {
            return value switch
            {
                "preserve-deleted" => TemplatesSaveTemplateVersionRequestBlockReconciliationStrategy.PreserveDeleted,
                "reconcile-all" => TemplatesSaveTemplateVersionRequestBlockReconciliationStrategy.ReconcileAll,
                _ => null,
            };
        }
    }
}