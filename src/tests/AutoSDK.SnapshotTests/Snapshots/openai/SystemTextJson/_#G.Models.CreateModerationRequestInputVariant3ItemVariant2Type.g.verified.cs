//HintName: G.Models.CreateModerationRequestInputVariant3ItemVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `text`.
    /// </summary>
    public enum CreateModerationRequestInputVariant3ItemVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModerationRequestInputVariant3ItemVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationRequestInputVariant3ItemVariant2Type value)
        {
            return value switch
            {
                CreateModerationRequestInputVariant3ItemVariant2Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationRequestInputVariant3ItemVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateModerationRequestInputVariant3ItemVariant2Type.Text,
                _ => null,
            };
        }
    }
}