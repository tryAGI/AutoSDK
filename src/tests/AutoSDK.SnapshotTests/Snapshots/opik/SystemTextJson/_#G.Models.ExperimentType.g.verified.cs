//HintName: G.Models.ExperimentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExperimentType
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