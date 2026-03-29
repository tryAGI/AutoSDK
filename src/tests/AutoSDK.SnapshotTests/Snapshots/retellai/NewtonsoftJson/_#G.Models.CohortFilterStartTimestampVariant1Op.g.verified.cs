//HintName: G.Models.CohortFilterStartTimestampVariant1Op.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CohortFilterStartTimestampVariant1Op
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ge")]
        Ge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CohortFilterStartTimestampVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CohortFilterStartTimestampVariant1Op value)
        {
            return value switch
            {
                CohortFilterStartTimestampVariant1Op.Ge => "ge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CohortFilterStartTimestampVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "ge" => CohortFilterStartTimestampVariant1Op.Ge,
                _ => null,
            };
        }
    }
}