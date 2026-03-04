//HintName: G.Models.ModelPublicServiceGetNamespaceLatestModelOperationView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelPublicServiceGetNamespaceLatestModelOperationView
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
    public static class ModelPublicServiceGetNamespaceLatestModelOperationViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPublicServiceGetNamespaceLatestModelOperationView value)
        {
            return value switch
            {
                ModelPublicServiceGetNamespaceLatestModelOperationView.ViewBasic => "VIEW_BASIC",
                ModelPublicServiceGetNamespaceLatestModelOperationView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPublicServiceGetNamespaceLatestModelOperationView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ModelPublicServiceGetNamespaceLatestModelOperationView.ViewBasic,
                "VIEW_FULL" => ModelPublicServiceGetNamespaceLatestModelOperationView.ViewFull,
                _ => null,
            };
        }
    }
}