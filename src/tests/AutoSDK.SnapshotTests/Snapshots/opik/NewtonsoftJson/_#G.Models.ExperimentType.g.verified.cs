//HintName: G.Models.ExperimentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExperimentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mini-batch")]
        MiniBatch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mutation")]
        Mutation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="regular")]
        Regular,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trial")]
        Trial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExperimentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentType value)
        {
            return value switch
            {
                ExperimentType.MiniBatch => "mini-batch",
                ExperimentType.Mutation => "mutation",
                ExperimentType.Regular => "regular",
                ExperimentType.Trial => "trial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentType? ToEnum(string value)
        {
            return value switch
            {
                "mini-batch" => ExperimentType.MiniBatch,
                "mutation" => ExperimentType.Mutation,
                "regular" => ExperimentType.Regular,
                "trial" => ExperimentType.Trial,
                _ => null,
            };
        }
    }
}