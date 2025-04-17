//HintName: G.Models.JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType
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
    public static class JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType value)
        {
            return value switch
            {
                JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType.Classifier => "classifier",
                JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType? ToEnum(string value)
        {
            return value switch
            {
                "classifier" => JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType.Classifier,
                "completion" => JobsApiRoutesFineTuningCreateFineTuningJobResponseVariant1DiscriminatorJobType.Completion,
                _ => null,
            };
        }
    }
}