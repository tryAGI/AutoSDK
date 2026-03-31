//HintName: G.Models.CreateStreamResponseJsepType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The session description object describes the initial proposal in an offer/answer exchange.
    /// </summary>
    public enum CreateStreamResponseJsepType2
    {
        /// <summary>
        /// 
        /// </summary>
        Offer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStreamResponseJsepType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStreamResponseJsepType2 value)
        {
            return value switch
            {
                CreateStreamResponseJsepType2.Offer => "offer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStreamResponseJsepType2? ToEnum(string value)
        {
            return value switch
            {
                "offer" => CreateStreamResponseJsepType2.Offer,
                _ => null,
            };
        }
    }
}