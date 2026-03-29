//HintName: G.Models.ExperimentPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExperimentPublicType
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
    public static class ExperimentPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentPublicType value)
        {
            return value switch
            {
                ExperimentPublicType.MiniBatch => "mini-batch",
                ExperimentPublicType.Mutation => "mutation",
                ExperimentPublicType.Regular => "regular",
                ExperimentPublicType.Trial => "trial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentPublicType? ToEnum(string value)
        {
            return value switch
            {
                "mini-batch" => ExperimentPublicType.MiniBatch,
                "mutation" => ExperimentPublicType.Mutation,
                "regular" => ExperimentPublicType.Regular,
                "trial" => ExperimentPublicType.Trial,
                _ => null,
            };
        }
    }
}