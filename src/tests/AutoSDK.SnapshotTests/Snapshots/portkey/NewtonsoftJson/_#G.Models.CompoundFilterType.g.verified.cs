//HintName: G.Models.CompoundFilterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of operation: `and` or `or`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompoundFilterType
    {
        /// <summary>
        /// `and` or `or`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="and")]
        And,
        /// <summary>
        /// `and` or `or`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="or")]
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompoundFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompoundFilterType value)
        {
            return value switch
            {
                CompoundFilterType.And => "and",
                CompoundFilterType.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompoundFilterType? ToEnum(string value)
        {
            return value switch
            {
                "and" => CompoundFilterType.And,
                "or" => CompoundFilterType.Or,
                _ => null,
            };
        }
    }
}