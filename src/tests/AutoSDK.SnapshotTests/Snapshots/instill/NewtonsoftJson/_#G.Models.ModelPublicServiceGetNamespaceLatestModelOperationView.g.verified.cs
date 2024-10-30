//HintName: G.Models.ModelPublicServiceGetNamespaceLatestModelOperationView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelPublicServiceGetNamespaceLatestModelOperationView
    {
        /// <summary>
        /// Default view, only includes basic information (omits `model_spec`).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_BASIC")]
        VIEWBASIC,
        /// <summary>
        /// Full representation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_FULL")]
        VIEWFULL,
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
                ModelPublicServiceGetNamespaceLatestModelOperationView.VIEWBASIC => "VIEW_BASIC",
                ModelPublicServiceGetNamespaceLatestModelOperationView.VIEWFULL => "VIEW_FULL",
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
                "VIEW_BASIC" => ModelPublicServiceGetNamespaceLatestModelOperationView.VIEWBASIC,
                "VIEW_FULL" => ModelPublicServiceGetNamespaceLatestModelOperationView.VIEWFULL,
                _ => null,
            };
        }
    }
}