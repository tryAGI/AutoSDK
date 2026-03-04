//HintName: G.Models.ModelPublicServiceListNamespaceModelsView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelPublicServiceListNamespaceModelsView
    {
        /// <summary>
        /// Default view, only includes basic information (omits `model_spec`).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_BASIC")]
        ViewBasic,
        /// <summary>
        /// Full representation.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_FULL")]
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