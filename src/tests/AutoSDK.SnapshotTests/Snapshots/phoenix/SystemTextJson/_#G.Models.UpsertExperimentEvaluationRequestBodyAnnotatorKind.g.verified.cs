//HintName: G.Models.UpsertExperimentEvaluationRequestBodyAnnotatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The kind of annotator used for the evaluation
    /// </summary>
    public enum UpsertExperimentEvaluationRequestBodyAnnotatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Human,
        /// <summary>
        /// 
        /// </summary>
        Llm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpsertExperimentEvaluationRequestBodyAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpsertExperimentEvaluationRequestBodyAnnotatorKind value)
        {
            return value switch
            {
                UpsertExperimentEvaluationRequestBodyAnnotatorKind.Code => "CODE",
                UpsertExperimentEvaluationRequestBodyAnnotatorKind.Human => "HUMAN",
                UpsertExperimentEvaluationRequestBodyAnnotatorKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpsertExperimentEvaluationRequestBodyAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "CODE" => UpsertExperimentEvaluationRequestBodyAnnotatorKind.Code,
                "HUMAN" => UpsertExperimentEvaluationRequestBodyAnnotatorKind.Human,
                "LLM" => UpsertExperimentEvaluationRequestBodyAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}