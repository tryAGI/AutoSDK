//HintName: G.Models.CodeBundleLocationExperimentPositionVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeBundleLocationExperimentPositionVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="task")]
        Task,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeBundleLocationExperimentPositionVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeBundleLocationExperimentPositionVariant1Type value)
        {
            return value switch
            {
                CodeBundleLocationExperimentPositionVariant1Type.Task => "task",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeBundleLocationExperimentPositionVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "task" => CodeBundleLocationExperimentPositionVariant1Type.Task,
                _ => null,
            };
        }
    }
}