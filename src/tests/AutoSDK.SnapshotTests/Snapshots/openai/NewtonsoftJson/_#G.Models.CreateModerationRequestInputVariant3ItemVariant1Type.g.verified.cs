//HintName: G.Models.CreateModerationRequestInputVariant3ItemVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `image_url`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModerationRequestInputVariant3ItemVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_url")]
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModerationRequestInputVariant3ItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationRequestInputVariant3ItemVariant1Type value)
        {
            return value switch
            {
                CreateModerationRequestInputVariant3ItemVariant1Type.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationRequestInputVariant3ItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => CreateModerationRequestInputVariant3ItemVariant1Type.ImageUrl,
                _ => null,
            };
        }
    }
}