//HintName: G.Models.ExperimentUpdateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExperimentUpdateType
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
    public static class ExperimentUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentUpdateType value)
        {
            return value switch
            {
                ExperimentUpdateType.MiniBatch => "mini-batch",
                ExperimentUpdateType.Mutation => "mutation",
                ExperimentUpdateType.Regular => "regular",
                ExperimentUpdateType.Trial => "trial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "mini-batch" => ExperimentUpdateType.MiniBatch,
                "mutation" => ExperimentUpdateType.Mutation,
                "regular" => ExperimentUpdateType.Regular,
                "trial" => ExperimentUpdateType.Trial,
                _ => null,
            };
        }
    }
}