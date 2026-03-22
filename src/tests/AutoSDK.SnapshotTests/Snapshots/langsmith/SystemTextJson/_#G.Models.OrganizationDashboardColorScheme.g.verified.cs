//HintName: G.Models.OrganizationDashboardColorScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for acceptable color schemes of dashboards.
    /// </summary>
    public enum OrganizationDashboardColorScheme
    {
        /// <summary>
        /// 
        /// </summary>
        Dark,
        /// <summary>
        /// 
        /// </summary>
        Light,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationDashboardColorSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationDashboardColorScheme value)
        {
            return value switch
            {
                OrganizationDashboardColorScheme.Dark => "dark",
                OrganizationDashboardColorScheme.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationDashboardColorScheme? ToEnum(string value)
        {
            return value switch
            {
                "dark" => OrganizationDashboardColorScheme.Dark,
                "light" => OrganizationDashboardColorScheme.Light,
                _ => null,
            };
        }
    }
}