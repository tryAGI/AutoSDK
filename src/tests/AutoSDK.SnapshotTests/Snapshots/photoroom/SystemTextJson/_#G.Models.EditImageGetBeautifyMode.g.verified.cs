//HintName: G.Models.EditImageGetBeautifyMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditImageGetBeautifyMode
    {
        /// <summary>
        /// 
        /// </summary>
        AiAuto,
        /// <summary>
        /// 
        /// </summary>
        AiCar,
        /// <summary>
        /// 
        /// </summary>
        AiFood,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetBeautifyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetBeautifyMode value)
        {
            return value switch
            {
                EditImageGetBeautifyMode.AiAuto => "ai.auto",
                EditImageGetBeautifyMode.AiCar => "ai.car",
                EditImageGetBeautifyMode.AiFood => "ai.food",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetBeautifyMode? ToEnum(string value)
        {
            return value switch
            {
                "ai.auto" => EditImageGetBeautifyMode.AiAuto,
                "ai.car" => EditImageGetBeautifyMode.AiCar,
                "ai.food" => EditImageGetBeautifyMode.AiFood,
                _ => null,
            };
        }
    }
}