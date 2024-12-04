//HintName: G.Models.PredictionContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the predicted content you want to provide. This type is<br/>
    /// currently always `content`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PredictionContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="content")]
        Content,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionContentType value)
        {
            return value switch
            {
                PredictionContentType.Content => "content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionContentType? ToEnum(string value)
        {
            return value switch
            {
                "content" => PredictionContentType.Content,
                _ => null,
            };
        }
    }
}