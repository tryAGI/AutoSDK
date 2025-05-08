//HintName: G.Models.EvalTextSimilarityGraderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of grader.<br/>
    /// Default Value: text_similarity
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalTextSimilarityGraderType
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
    public static class EvalTextSimilarityGraderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalTextSimilarityGraderType value)
        {
            return value switch
            {
                EvalTextSimilarityGraderType.TextSimilarity => "text_similarity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalTextSimilarityGraderType? ToEnum(string value)
        {
            return value switch
            {
                "text_similarity" => EvalTextSimilarityGraderType.TextSimilarity,
                _ => null,
            };
        }
    }
}