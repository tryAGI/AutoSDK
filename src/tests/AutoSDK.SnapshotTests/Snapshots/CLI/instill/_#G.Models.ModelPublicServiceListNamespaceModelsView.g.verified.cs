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
        VIEWBASIC,
        /// <summary>
        /// Full representation.
        /// </summary>
        VIEWFULL,
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
                ModelPublicServiceListNamespaceModelsView.VIEWBASIC => "VIEW_BASIC",
                ModelPublicServiceListNamespaceModelsView.VIEWFULL => "VIEW_FULL",
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
                "VIEW_BASIC" => ModelPublicServiceListNamespaceModelsView.VIEWBASIC,
                "VIEW_FULL" => ModelPublicServiceListNamespaceModelsView.VIEWFULL,
                _ => null,
            };
        }
    }
}