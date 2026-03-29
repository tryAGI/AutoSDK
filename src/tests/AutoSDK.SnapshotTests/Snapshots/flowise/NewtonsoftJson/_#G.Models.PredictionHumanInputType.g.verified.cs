//HintName: G.Models.PredictionHumanInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of human input response<br/>
    /// Example: reject
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PredictionHumanInputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="proceed")]
        Proceed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reject")]
        Reject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionHumanInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionHumanInputType value)
        {
            return value switch
            {
                PredictionHumanInputType.Proceed => "proceed",
                PredictionHumanInputType.Reject => "reject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionHumanInputType? ToEnum(string value)
        {
            return value switch
            {
                "proceed" => PredictionHumanInputType.Proceed,
                "reject" => PredictionHumanInputType.Reject,
                _ => null,
            };
        }
    }
}