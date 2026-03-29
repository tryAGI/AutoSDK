//HintName: G.Models.StartConnection1RequestAnswerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The SDP contained in the sdp property is the definitive choice in the exchange. In other words, this session<br/>
    /// description describes the agreed-upon configuration, and is being sent to finalize negotiation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StartConnection1RequestAnswerType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="answer")]
        Answer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StartConnection1RequestAnswerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartConnection1RequestAnswerType value)
        {
            return value switch
            {
                StartConnection1RequestAnswerType.Answer => "answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartConnection1RequestAnswerType? ToEnum(string value)
        {
            return value switch
            {
                "answer" => StartConnection1RequestAnswerType.Answer,
                _ => null,
            };
        }
    }
}