//HintName: G.Models.ModelPublicServiceGetNamespaceModelOperationView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelPublicServiceGetNamespaceModelOperationView
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
    public static class ModelPublicServiceGetNamespaceModelOperationViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPublicServiceGetNamespaceModelOperationView value)
        {
            return value switch
            {
                ModelPublicServiceGetNamespaceModelOperationView.VIEWBASIC => "VIEW_BASIC",
                ModelPublicServiceGetNamespaceModelOperationView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPublicServiceGetNamespaceModelOperationView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ModelPublicServiceGetNamespaceModelOperationView.VIEWBASIC,
                "VIEW_FULL" => ModelPublicServiceGetNamespaceModelOperationView.VIEWFULL,
                _ => null,
            };
        }
    }
}