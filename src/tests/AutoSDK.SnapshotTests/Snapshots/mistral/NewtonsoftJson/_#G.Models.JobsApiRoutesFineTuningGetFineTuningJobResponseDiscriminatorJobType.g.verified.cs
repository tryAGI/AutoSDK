//HintName: G.Models.JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="classifier")]
        Classifier,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completion")]
        Completion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType value)
        {
            return value switch
            {
                JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType.Classifier => "classifier",
                JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType? ToEnum(string value)
        {
            return value switch
            {
                "classifier" => JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType.Classifier,
                "completion" => JobsApiRoutesFineTuningGetFineTuningJobResponseDiscriminatorJobType.Completion,
                _ => null,
            };
        }
    }
}