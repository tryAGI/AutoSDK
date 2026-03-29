//HintName: G.Models.AlertIncidentResponseComparator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Comparison operator for the threshold.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertIncidentResponseComparator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ge")]
        Ge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gt")]
        Gt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="le")]
        Le,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lt")]
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