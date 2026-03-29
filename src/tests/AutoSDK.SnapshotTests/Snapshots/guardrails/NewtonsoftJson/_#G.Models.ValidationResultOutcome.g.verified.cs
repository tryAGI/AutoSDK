//HintName: G.Models.ValidationResultOutcome.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether validation passed or failed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ValidationResultOutcome
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fail")]
        Fail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pass")]
        Pass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValidationResultOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValidationResultOutcome value)
        {
            return value switch
            {
                ValidationResultOutcome.Fail => "fail",
                ValidationResultOutcome.Pass => "pass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValidationResultOutcome? ToEnum(string value)
        {
            return value switch
            {
                "fail" => ValidationResultOutcome.Fail,
                "pass" => ValidationResultOutcome.Pass,
                _ => null,
            };
        }
    }
}