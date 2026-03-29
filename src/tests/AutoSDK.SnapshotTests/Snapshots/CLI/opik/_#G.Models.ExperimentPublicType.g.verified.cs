//HintName: G.Models.ExperimentPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExperimentPublicType
    {
        /// <summary>
        /// 
        /// </summary>
        MiniBatch,
        /// <summary>
        /// 
        /// </summary>
        Mutation,
        /// <summary>
        /// 
        /// </summary>
        Regular,
        /// <summary>
        /// 
        /// </summary>
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