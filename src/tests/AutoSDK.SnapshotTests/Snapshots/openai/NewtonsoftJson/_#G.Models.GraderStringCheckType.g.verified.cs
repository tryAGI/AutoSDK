//HintName: G.Models.GraderStringCheckType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `string_check`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GraderStringCheckType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string_check")]
        StringCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraderStringCheckTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraderStringCheckType value)
        {
            return value switch
            {
                GraderStringCheckType.StringCheck => "string_check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraderStringCheckType? ToEnum(string value)
        {
            return value switch
            {
                "string_check" => GraderStringCheckType.StringCheck,
                _ => null,
            };
        }
    }
}