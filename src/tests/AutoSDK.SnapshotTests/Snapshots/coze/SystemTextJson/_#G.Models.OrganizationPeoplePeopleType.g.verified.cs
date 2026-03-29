//HintName: G.Models.OrganizationPeoplePeopleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrganizationPeoplePeopleType
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
    public static class OrganizationPeoplePeopleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationPeoplePeopleType value)
        {
            return value switch
            {
                OrganizationPeoplePeopleType.Employee => "employee",
                OrganizationPeoplePeopleType.Guest => "guest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationPeoplePeopleType? ToEnum(string value)
        {
            return value switch
            {
                "employee" => OrganizationPeoplePeopleType.Employee,
                "guest" => OrganizationPeoplePeopleType.Guest,
                _ => null,
            };
        }
    }
}