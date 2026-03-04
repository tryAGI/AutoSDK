//HintName: G.Models.ModelPublicServiceListNamespaceModelsView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelPublicServiceListNamespaceModelsView
    {
        /// <summary>
        /// Default view, only includes basic information (omits `model_spec`).
        /// </summary>
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        ViewFull,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelPublicServiceListNamespaceModelsViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPublicServiceListNamespaceModelsView value)
        {
            return value switch
            {
                ModelPublicServiceListNamespaceModelsView.ViewBasic => "VIEW_BASIC",
                ModelPublicServiceListNamespaceModelsView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPublicServiceListNamespaceModelsView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ModelPublicServiceListNamespaceModelsView.ViewBasic,
                "VIEW_FULL" => ModelPublicServiceListNamespaceModelsView.ViewFull,
                _ => null,
            };
        }
    }
}