//HintName: G.Models.AnalysisCostAnalysisType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of analysis performed.
    /// </summary>
    public enum AnalysisCostAnalysisType
    {
        /// <summary>
        /// 
        /// </summary>
        StructuredData,
        /// <summary>
        /// 
        /// </summary>
        StructuredOutput,
        /// <summary>
        /// 
        /// </summary>
        SuccessEvaluation,
        /// <summary>
        /// 
        /// </summary>
        Summary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalysisCostAnalysisTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalysisCostAnalysisType value)
        {
            return value switch
            {
                AnalysisCostAnalysisType.StructuredData => "structuredData",
                AnalysisCostAnalysisType.StructuredOutput => "structuredOutput",
                AnalysisCostAnalysisType.SuccessEvaluation => "successEvaluation",
                AnalysisCostAnalysisType.Summary => "summary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalysisCostAnalysisType? ToEnum(string value)
        {
            return value switch
            {
                "structuredData" => AnalysisCostAnalysisType.StructuredData,
                "structuredOutput" => AnalysisCostAnalysisType.StructuredOutput,
                "successEvaluation" => AnalysisCostAnalysisType.SuccessEvaluation,
                "summary" => AnalysisCostAnalysisType.Summary,
                _ => null,
            };
        }
    }
}