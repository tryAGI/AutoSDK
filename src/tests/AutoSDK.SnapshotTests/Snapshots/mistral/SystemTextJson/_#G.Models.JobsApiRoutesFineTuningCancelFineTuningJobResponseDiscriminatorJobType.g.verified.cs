//HintName: G.Models.JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType
    {
        /// <summary>
        /// 
        /// </summary>
        Classifier,
        /// <summary>
        /// 
        /// </summary>
        Completion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType value)
        {
            return value switch
            {
                JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType.Classifier => "classifier",
                JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType? ToEnum(string value)
        {
            return value switch
            {
                "classifier" => JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType.Classifier,
                "completion" => JobsApiRoutesFineTuningCancelFineTuningJobResponseDiscriminatorJobType.Completion,
                _ => null,
            };
        }
    }
}