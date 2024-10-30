//HintName: G.Models.ModelPublicServiceListNamespaceModelsVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelPublicServiceListNamespaceModelsVisibility
    {
        /// <summary>
        /// Only the owner can see the model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VISIBILITY_PRIVATE")]
        VISIBILITYPRIVATE,
        /// <summary>
        /// Other users can see the model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VISIBILITY_PUBLIC")]
        VISIBILITYPUBLIC,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelPublicServiceListNamespaceModelsVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPublicServiceListNamespaceModelsVisibility value)
        {
            return value switch
            {
                ModelPublicServiceListNamespaceModelsVisibility.VISIBILITYPRIVATE => "VISIBILITY_PRIVATE",
                ModelPublicServiceListNamespaceModelsVisibility.VISIBILITYPUBLIC => "VISIBILITY_PUBLIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPublicServiceListNamespaceModelsVisibility? ToEnum(string value)
        {
            return value switch
            {
                "VISIBILITY_PRIVATE" => ModelPublicServiceListNamespaceModelsVisibility.VISIBILITYPRIVATE,
                "VISIBILITY_PUBLIC" => ModelPublicServiceListNamespaceModelsVisibility.VISIBILITYPUBLIC,
                _ => null,
            };
        }
    }
}