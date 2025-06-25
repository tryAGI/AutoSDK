//HintName: G.Models.DependabotListAlertsForEnterpriseDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum DependabotListAlertsForEnterpriseDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotListAlertsForEnterpriseDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotListAlertsForEnterpriseDirection value)
        {
            return value switch
            {
                DependabotListAlertsForEnterpriseDirection.Asc => "asc",
                DependabotListAlertsForEnterpriseDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotListAlertsForEnterpriseDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => DependabotListAlertsForEnterpriseDirection.Asc,
                "desc" => DependabotListAlertsForEnterpriseDirection.Desc,
                _ => null,
            };
        }
    }
}