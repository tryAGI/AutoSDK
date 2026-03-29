//HintName: G.Models.ExperimentEvaluationMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExperimentEvaluationMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        EvaluationSuite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExperimentEvaluationMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentEvaluationMethod value)
        {
            return value switch
            {
                ExperimentEvaluationMethod.Dataset => "dataset",
                ExperimentEvaluationMethod.EvaluationSuite => "evaluation_suite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentEvaluationMethod? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ExperimentEvaluationMethod.Dataset,
                "evaluation_suite" => ExperimentEvaluationMethod.EvaluationSuite,
                _ => null,
            };
        }
    }
}