//HintName: G.Models.GraderTextSimilarityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of grader.<br/>
    /// Default Value: text_similarity
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GraderTextSimilarityType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text_similarity")]
        TextSimilarity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraderTextSimilarityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraderTextSimilarityType value)
        {
            return value switch
            {
                GraderTextSimilarityType.TextSimilarity => "text_similarity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraderTextSimilarityType? ToEnum(string value)
        {
            return value switch
            {
                "text_similarity" => GraderTextSimilarityType.TextSimilarity,
                _ => null,
            };
        }
    }
}