//HintName: G.Models.EditionEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `Community` - Community<br/>
    /// * `Enterprise` - Enterprise
    /// </summary>
    public enum EditionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Community,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditionEnum value)
        {
            return value switch
            {
                EditionEnum.Community => "Community",
                EditionEnum.Enterprise => "Enterprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditionEnum? ToEnum(string value)
        {
            return value switch
            {
                "Community" => EditionEnum.Community,
                "Enterprise" => EditionEnum.Enterprise,
                _ => null,
            };
        }
    }
}