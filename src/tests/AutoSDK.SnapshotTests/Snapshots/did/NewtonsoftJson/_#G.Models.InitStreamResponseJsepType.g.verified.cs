//HintName: G.Models.InitStreamResponseJsepType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The session description object describes the initial proposal in an offer/answer exchange.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InitStreamResponseJsepType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="offer")]
        Offer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InitStreamResponseJsepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InitStreamResponseJsepType value)
        {
            return value switch
            {
                InitStreamResponseJsepType.Offer => "offer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InitStreamResponseJsepType? ToEnum(string value)
        {
            return value switch
            {
                "offer" => InitStreamResponseJsepType.Offer,
                _ => null,
            };
        }
    }
}