//HintName: G.Models.DependabotListAlertsForOrgDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotListAlertsForOrgDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotListAlertsForOrgDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotListAlertsForOrgDirection value)
        {
            return value switch
            {
                DependabotListAlertsForOrgDirection.Asc => "asc",
                DependabotListAlertsForOrgDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotListAlertsForOrgDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => DependabotListAlertsForOrgDirection.Asc,
                "desc" => DependabotListAlertsForOrgDirection.Desc,
                _ => null,
            };
        }
    }
}