//HintName: G.Models.ControlnetInputInitImageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type indicating whether the init image is uploaded or generated.
    /// </summary>
    public enum ControlnetInputInitImageType
    {
        /// <summary>
        /// 
        /// </summary>
        GENERATED,
        /// <summary>
        /// 
        /// </summary>
        UPLOADED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ControlnetInputInitImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ControlnetInputInitImageType value)
        {
            return value switch
            {
                ControlnetInputInitImageType.GENERATED => "GENERATED",
                ControlnetInputInitImageType.UPLOADED => "UPLOADED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ControlnetInputInitImageType? ToEnum(string value)
        {
            return value switch
            {
                "GENERATED" => ControlnetInputInitImageType.GENERATED,
                "UPLOADED" => ControlnetInputInitImageType.UPLOADED,
                _ => null,
            };
        }
    }
}