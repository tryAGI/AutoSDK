//HintName: G.Models.SamplingDe5Enum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `Sequential sampling` - Tasks are ordered by Data manager ordering<br/>
    /// * `Uniform sampling` - Tasks are chosen randomly<br/>
    /// * `Uncertainty sampling` - Tasks are chosen according to model uncertainty scores (active learning mode)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SamplingDe5Enum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Sequential sampling")]
        SequentialSampling,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Uncertainty sampling")]
        UncertaintySampling,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Uniform sampling")]
        UniformSampling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SamplingDe5EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SamplingDe5Enum value)
        {
            return value switch
            {
                SamplingDe5Enum.SequentialSampling => "Sequential sampling",
                SamplingDe5Enum.UncertaintySampling => "Uncertainty sampling",
                SamplingDe5Enum.UniformSampling => "Uniform sampling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SamplingDe5Enum? ToEnum(string value)
        {
            return value switch
            {
                "Sequential sampling" => SamplingDe5Enum.SequentialSampling,
                "Uncertainty sampling" => SamplingDe5Enum.UncertaintySampling,
                "Uniform sampling" => SamplingDe5Enum.UniformSampling,
                _ => null,
            };
        }
    }
}