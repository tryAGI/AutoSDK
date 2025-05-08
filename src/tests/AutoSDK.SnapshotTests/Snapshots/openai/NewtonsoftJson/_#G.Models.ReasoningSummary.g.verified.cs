//HintName: G.Models.ReasoningSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A summary of the reasoning performed by the model. This can be<br/>
    /// useful for debugging and understanding the model's reasoning process.<br/>
    /// One of `auto`, `concise`, or `detailed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReasoningSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="concise")]
        Concise,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="detailed")]
        Detailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningSummaryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningSummary value)
        {
            return value switch
            {
                ReasoningSummary.Auto => "auto",
                ReasoningSummary.Concise => "concise",
                ReasoningSummary.Detailed => "detailed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningSummary? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ReasoningSummary.Auto,
                "concise" => ReasoningSummary.Concise,
                "detailed" => ReasoningSummary.Detailed,
                _ => null,
            };
        }
    }
}