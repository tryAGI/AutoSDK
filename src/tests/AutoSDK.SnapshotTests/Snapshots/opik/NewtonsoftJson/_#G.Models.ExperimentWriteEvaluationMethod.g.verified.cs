//HintName: G.Models.ExperimentWriteEvaluationMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExperimentWriteEvaluationMethod
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
    public static class ExperimentWriteEvaluationMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentWriteEvaluationMethod value)
        {
            return value switch
            {
                ExperimentWriteEvaluationMethod.Dataset => "dataset",
                ExperimentWriteEvaluationMethod.EvaluationSuite => "evaluation_suite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentWriteEvaluationMethod? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ExperimentWriteEvaluationMethod.Dataset,
                "evaluation_suite" => ExperimentWriteEvaluationMethod.EvaluationSuite,
                _ => null,
            };
        }
    }
}