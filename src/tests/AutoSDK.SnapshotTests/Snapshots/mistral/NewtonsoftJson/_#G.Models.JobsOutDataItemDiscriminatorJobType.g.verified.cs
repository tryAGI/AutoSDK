//HintName: G.Models.JobsOutDataItemDiscriminatorJobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JobsOutDataItemDiscriminatorJobType
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
    public static class JobsOutDataItemDiscriminatorJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsOutDataItemDiscriminatorJobType value)
        {
            return value switch
            {
                JobsOutDataItemDiscriminatorJobType.Classifier => "classifier",
                JobsOutDataItemDiscriminatorJobType.Completion => "completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsOutDataItemDiscriminatorJobType? ToEnum(string value)
        {
            return value switch
            {
                "classifier" => JobsOutDataItemDiscriminatorJobType.Classifier,
                "completion" => JobsOutDataItemDiscriminatorJobType.Completion,
                _ => null,
            };
        }
    }
}