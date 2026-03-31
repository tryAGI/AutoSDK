//HintName: G.Models.CreateStartStreamRequestAnswerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The SDP contained in the sdp property is the definitive choice in the exchange. In other words, this session<br/>
    /// description describes the agreed-upon configuration, and is being sent to finalize negotiation.
    /// </summary>
    public enum CreateStartStreamRequestAnswerType
    {
        /// <summary>
        /// 
        /// </summary>
        Answer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStartStreamRequestAnswerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStartStreamRequestAnswerType value)
        {
            return value switch
            {
                CreateStartStreamRequestAnswerType.Answer => "answer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStartStreamRequestAnswerType? ToEnum(string value)
        {
            return value switch
            {
                "answer" => CreateStartStreamRequestAnswerType.Answer,
                _ => null,
            };
        }
    }
}