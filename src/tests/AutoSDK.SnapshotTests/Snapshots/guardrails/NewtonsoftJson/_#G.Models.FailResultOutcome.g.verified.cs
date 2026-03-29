//HintName: G.Models.FailResultOutcome.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always 'fail' for FailResult.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FailResultOutcome
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fail")]
        Fail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FailResultOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FailResultOutcome value)
        {
            return value switch
            {
                FailResultOutcome.Fail => "fail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FailResultOutcome? ToEnum(string value)
        {
            return value switch
            {
                "fail" => FailResultOutcome.Fail,
                _ => null,
            };
        }
    }
}