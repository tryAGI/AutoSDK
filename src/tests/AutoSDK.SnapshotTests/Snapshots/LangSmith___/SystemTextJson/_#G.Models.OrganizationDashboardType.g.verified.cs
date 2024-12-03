//HintName: G.Models.OrganizationDashboardType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for acceptable types of dashboards.
    /// </summary>
    public enum OrganizationDashboardType
    {
        /// <summary>
        /// 
        /// </summary>
        Invoices,
        /// <summary>
        /// 
        /// </summary>
        Usage,
        /// <summary>
        /// 
        /// </summary>
        Credits,
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
                OrganizationDashboardType.Invoices => "invoices",
                OrganizationDashboardType.Usage => "usage",
                OrganizationDashboardType.Credits => "credits",
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
                "invoices" => OrganizationDashboardType.Invoices,
                "usage" => OrganizationDashboardType.Usage,
                "credits" => OrganizationDashboardType.Credits,
                _ => null,
            };
        }
    }
}