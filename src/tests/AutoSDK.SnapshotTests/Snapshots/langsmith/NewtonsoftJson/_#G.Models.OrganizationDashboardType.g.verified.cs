//HintName: G.Models.OrganizationDashboardType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for acceptable types of dashboards.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrganizationDashboardType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="credits")]
        Credits,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invoices")]
        Invoices,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="usage")]
        Usage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationDashboardTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationDashboardType value)
        {
            return value switch
            {
                OrganizationDashboardType.Credits => "credits",
                OrganizationDashboardType.Invoices => "invoices",
                OrganizationDashboardType.Usage => "usage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationDashboardType? ToEnum(string value)
        {
            return value switch
            {
                "credits" => OrganizationDashboardType.Credits,
                "invoices" => OrganizationDashboardType.Invoices,
                "usage" => OrganizationDashboardType.Usage,
                _ => null,
            };
        }
    }
}