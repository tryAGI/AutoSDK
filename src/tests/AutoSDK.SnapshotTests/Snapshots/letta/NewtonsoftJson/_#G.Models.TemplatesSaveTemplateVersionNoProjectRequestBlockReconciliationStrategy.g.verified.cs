//HintName: G.Models.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Strategy for reconciling memory blocks during migration: "reconcile-all" deletes blocks not in the template, "preserve-deleted" keeps them. Defaults to "preserve-deleted".
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy
    {
        /// <summary>
        /// "reconcile-all" deletes blocks not in the template, "preserve-deleted" keeps them. Defaults to "preserve-deleted".
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="preserve-deleted")]
        PreserveDeleted,
        /// <summary>
        /// "reconcile-all" deletes blocks not in the template, "preserve-deleted" keeps them. Defaults to "preserve-deleted".
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reconcile-all")]
        ReconcileAll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy value)
        {
            return value switch
            {
                TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy.PreserveDeleted => "preserve-deleted",
                TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy.ReconcileAll => "reconcile-all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy? ToEnum(string value)
        {
            return value switch
            {
                "preserve-deleted" => TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy.PreserveDeleted,
                "reconcile-all" => TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy.ReconcileAll,
                _ => null,
            };
        }
    }
}