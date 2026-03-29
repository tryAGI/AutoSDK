//HintName: G.Models.ExperimentWriteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExperimentWriteType
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
    public static class ExperimentWriteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentWriteType value)
        {
            return value switch
            {
                ExperimentWriteType.MiniBatch => "mini-batch",
                ExperimentWriteType.Mutation => "mutation",
                ExperimentWriteType.Regular => "regular",
                ExperimentWriteType.Trial => "trial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentWriteType? ToEnum(string value)
        {
            return value switch
            {
                "mini-batch" => ExperimentWriteType.MiniBatch,
                "mutation" => ExperimentWriteType.Mutation,
                "regular" => ExperimentWriteType.Regular,
                "trial" => ExperimentWriteType.Trial,
                _ => null,
            };
        }
    }
}