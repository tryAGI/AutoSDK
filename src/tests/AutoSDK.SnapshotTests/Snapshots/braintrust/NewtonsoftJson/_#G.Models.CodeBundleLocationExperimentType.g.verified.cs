//HintName: G.Models.CodeBundleLocationExperimentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeBundleLocationExperimentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiment")]
        Experiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeBundleLocationExperimentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeBundleLocationExperimentType value)
        {
            return value switch
            {
                CodeBundleLocationExperimentType.Experiment => "experiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeBundleLocationExperimentType? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => CodeBundleLocationExperimentType.Experiment,
                _ => null,
            };
        }
    }
}