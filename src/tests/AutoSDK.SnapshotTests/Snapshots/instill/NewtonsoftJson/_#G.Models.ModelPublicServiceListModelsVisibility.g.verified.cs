//HintName: G.Models.ModelPublicServiceListModelsVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelPublicServiceListModelsVisibility
    {
        /// <summary>
        /// Only the owner can see the model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VISIBILITY_PRIVATE")]
        VisibilityPrivate,
        /// <summary>
        /// Other users can see the model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VISIBILITY_PUBLIC")]
        VisibilityPublic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelPublicServiceListModelsVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPublicServiceListModelsVisibility value)
        {
            return value switch
            {
                ModelPublicServiceListModelsVisibility.VisibilityPrivate => "VISIBILITY_PRIVATE",
                ModelPublicServiceListModelsVisibility.VisibilityPublic => "VISIBILITY_PUBLIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPublicServiceListModelsVisibility? ToEnum(string value)
        {
            return value switch
            {
                "VISIBILITY_PRIVATE" => ModelPublicServiceListModelsVisibility.VisibilityPrivate,
                "VISIBILITY_PUBLIC" => ModelPublicServiceListModelsVisibility.VisibilityPublic,
                _ => null,
            };
        }
    }
}