//HintName: G.Models.AlertIncidentResponseComparator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comparison operator for the threshold.
    /// </summary>
    public enum AlertIncidentResponseComparator
    {
        /// <summary>
        /// 
        /// </summary>
        Ge,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Le,
        /// <summary>
        /// 
        /// </summary>
        Lt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertIncidentResponseComparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertIncidentResponseComparator value)
        {
            return value switch
            {
                AlertIncidentResponseComparator.Ge => "ge",
                AlertIncidentResponseComparator.Gt => "gt",
                AlertIncidentResponseComparator.Le => "le",
                AlertIncidentResponseComparator.Lt => "lt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertIncidentResponseComparator? ToEnum(string value)
        {
            return value switch
            {
                "ge" => AlertIncidentResponseComparator.Ge,
                "gt" => AlertIncidentResponseComparator.Gt,
                "le" => AlertIncidentResponseComparator.Le,
                "lt" => AlertIncidentResponseComparator.Lt,
                _ => null,
            };
        }
    }
}