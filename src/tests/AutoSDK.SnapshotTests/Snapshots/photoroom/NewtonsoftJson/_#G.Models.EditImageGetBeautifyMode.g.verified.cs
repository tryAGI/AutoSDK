//HintName: G.Models.EditImageGetBeautifyMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetBeautifyMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.auto")]
        AiAuto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.car")]
        AiCar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.food")]
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