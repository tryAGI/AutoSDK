//HintName: G.Models.StartConnectionRequestAnswerType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The SDP contained in the sdp property is the definitive choice in the exchange. In other words, this session<br/>
    /// description describes the agreed-upon configuration, and is being sent to finalize negotiation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StartConnectionRequestAnswerType2
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
    public static class StartConnectionRequestAnswerType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartConnectionRequestAnswerType2 value)
        {
            return value switch
            {
                StartConnectionRequestAnswerType2.Answer => "answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartConnectionRequestAnswerType2? ToEnum(string value)
        {
            return value switch
            {
                "answer" => StartConnectionRequestAnswerType2.Answer,
                _ => null,
            };
        }
    }
}