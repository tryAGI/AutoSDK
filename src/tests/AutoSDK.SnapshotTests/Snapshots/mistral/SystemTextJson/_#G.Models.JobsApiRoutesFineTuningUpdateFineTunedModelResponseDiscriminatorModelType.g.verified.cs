//HintName: G.Models.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType
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
    public static class JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType value)
        {
            return value switch
            {
                JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType.Classifier => "classifier",
                JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType? ToEnum(string value)
        {
            return value switch
            {
                "classifier" => JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType.Classifier,
                "completion" => JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType.Completion,
                _ => null,
            };
        }
    }
}