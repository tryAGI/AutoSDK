//HintName: G.Models.ExperimentEvaluationMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExperimentEvaluationMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dataset")]
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="evaluation_suite")]
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