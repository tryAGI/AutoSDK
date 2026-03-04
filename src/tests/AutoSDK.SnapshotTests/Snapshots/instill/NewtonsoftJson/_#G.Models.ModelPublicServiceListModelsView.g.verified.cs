//HintName: G.Models.ModelPublicServiceListModelsView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelPublicServiceListModelsView
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
    public static class ModelPublicServiceListModelsViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPublicServiceListModelsView value)
        {
            return value switch
            {
                ModelPublicServiceListModelsView.ViewBasic => "VIEW_BASIC",
                ModelPublicServiceListModelsView.ViewFull => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPublicServiceListModelsView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => ModelPublicServiceListModelsView.ViewBasic,
                "VIEW_FULL" => ModelPublicServiceListModelsView.ViewFull,
                _ => null,
            };
        }
    }
}