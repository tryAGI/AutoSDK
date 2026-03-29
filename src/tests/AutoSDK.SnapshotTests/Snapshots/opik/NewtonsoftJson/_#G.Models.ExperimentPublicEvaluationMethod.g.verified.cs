//HintName: G.Models.ExperimentPublicEvaluationMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExperimentPublicEvaluationMethod
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
    public static class ExperimentPublicEvaluationMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentPublicEvaluationMethod value)
        {
            return value switch
            {
                ExperimentPublicEvaluationMethod.Dataset => "dataset",
                ExperimentPublicEvaluationMethod.EvaluationSuite => "evaluation_suite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentPublicEvaluationMethod? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ExperimentPublicEvaluationMethod.Dataset,
                "evaluation_suite" => ExperimentPublicEvaluationMethod.EvaluationSuite,
                _ => null,
            };
        }
    }
}