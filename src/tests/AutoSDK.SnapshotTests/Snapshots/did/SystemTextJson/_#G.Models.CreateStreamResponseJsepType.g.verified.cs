//HintName: G.Models.CreateStreamResponseJsepType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The session description object describes the initial proposal in an offer/answer exchange.
    /// </summary>
    public enum CreateStreamResponseJsepType
    {
        /// <summary>
        /// 
        /// </summary>
        Offer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStreamResponseJsepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStreamResponseJsepType value)
        {
            return value switch
            {
                CreateStreamResponseJsepType.Offer => "offer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStreamResponseJsepType? ToEnum(string value)
        {
            return value switch
            {
                "offer" => CreateStreamResponseJsepType.Offer,
                _ => null,
            };
        }
    }
}