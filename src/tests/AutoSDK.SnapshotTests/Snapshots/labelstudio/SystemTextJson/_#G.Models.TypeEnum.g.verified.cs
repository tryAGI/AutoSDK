//HintName: G.Models.TypeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `AN` - Annotate<br/>
    /// * `RE` - Review
    /// </summary>
    public enum TypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        An,
        /// <summary>
        /// 
        /// </summary>
        Re,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TypeEnum value)
        {
            return value switch
            {
                TypeEnum.An => "AN",
                TypeEnum.Re => "RE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "AN" => TypeEnum.An,
                "RE" => TypeEnum.Re,
                _ => null,
            };
        }
    }
}