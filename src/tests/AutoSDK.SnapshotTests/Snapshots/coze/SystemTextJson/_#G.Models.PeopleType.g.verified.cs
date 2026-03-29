//HintName: G.Models.PeopleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PeopleType
    {
        /// <summary>
        /// 
        /// </summary>
        Employee,
        /// <summary>
        /// 
        /// </summary>
        Guest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PeopleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PeopleType value)
        {
            return value switch
            {
                PeopleType.Employee => "employee",
                PeopleType.Guest => "guest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PeopleType? ToEnum(string value)
        {
            return value switch
            {
                "employee" => PeopleType.Employee,
                "guest" => PeopleType.Guest,
                _ => null,
            };
        }
    }
}