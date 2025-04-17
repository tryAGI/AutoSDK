//HintName: G.Models.PredictionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: content
    /// </summary>
    public enum PredictionType
    {
        /// <summary>
        /// 
        /// </summary>
        Content,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionType value)
        {
            return value switch
            {
                PredictionType.Content => "content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionType? ToEnum(string value)
        {
            return value switch
            {
                "content" => PredictionType.Content,
                _ => null,
            };
        }
    }
}