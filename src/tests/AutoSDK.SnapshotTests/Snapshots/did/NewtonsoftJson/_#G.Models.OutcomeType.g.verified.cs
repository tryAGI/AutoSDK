//HintName: G.Models.OutcomeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutcomeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Achieved")]
        Achieved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Not achieved")]
        NotAchieved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Partially achieved")]
        PartiallyAchieved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Unclear-definition")]
        UnclearDefinition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutcomeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutcomeType value)
        {
            return value switch
            {
                OutcomeType.Achieved => "Achieved",
                OutcomeType.NotAchieved => "Not achieved",
                OutcomeType.PartiallyAchieved => "Partially achieved",
                OutcomeType.UnclearDefinition => "Unclear-definition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutcomeType? ToEnum(string value)
        {
            return value switch
            {
                "Achieved" => OutcomeType.Achieved,
                "Not achieved" => OutcomeType.NotAchieved,
                "Partially achieved" => OutcomeType.PartiallyAchieved,
                "Unclear-definition" => OutcomeType.UnclearDefinition,
                _ => null,
            };
        }
    }
}