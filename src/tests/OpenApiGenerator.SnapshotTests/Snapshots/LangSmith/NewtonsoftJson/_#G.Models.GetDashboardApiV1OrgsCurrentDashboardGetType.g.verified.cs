//HintName: G.Models.GetDashboardApiV1OrgsCurrentDashboardGetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for acceptable types of dashboards.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetDashboardApiV1OrgsCurrentDashboardGetType
    {
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="credits")]
        Credits,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDashboardApiV1OrgsCurrentDashboardGetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDashboardApiV1OrgsCurrentDashboardGetType value)
        {
            return value switch
            {
                GetDashboardApiV1OrgsCurrentDashboardGetType.Invoices => "invoices",
                GetDashboardApiV1OrgsCurrentDashboardGetType.Usage => "usage",
                GetDashboardApiV1OrgsCurrentDashboardGetType.Credits => "credits",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDashboardApiV1OrgsCurrentDashboardGetType? ToEnum(string value)
        {
            return value switch
            {
                "invoices" => GetDashboardApiV1OrgsCurrentDashboardGetType.Invoices,
                "usage" => GetDashboardApiV1OrgsCurrentDashboardGetType.Usage,
                "credits" => GetDashboardApiV1OrgsCurrentDashboardGetType.Credits,
                _ => null,
            };
        }
    }
}