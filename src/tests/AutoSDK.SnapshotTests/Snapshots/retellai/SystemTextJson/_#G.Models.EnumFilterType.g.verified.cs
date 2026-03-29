//HintName: G.Models.EnumFilterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnumFilterType
    {
        /// <summary>
        /// 
        /// </summary>
        Enum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnumFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnumFilterType value)
        {
            return value switch
            {
                EnumFilterType.Enum => "enum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnumFilterType? ToEnum(string value)
        {
            return value switch
            {
                "enum" => EnumFilterType.Enum,
                _ => null,
            };
        }
    }
}