//HintName: G.Models.ExperimentItemTraceVisibilityMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExperimentItemTraceVisibilityMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hidden")]
        Hidden,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExperimentItemTraceVisibilityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentItemTraceVisibilityMode value)
        {
            return value switch
            {
                ExperimentItemTraceVisibilityMode.Default => "default",
                ExperimentItemTraceVisibilityMode.Hidden => "hidden",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentItemTraceVisibilityMode? ToEnum(string value)
        {
            return value switch
            {
                "default" => ExperimentItemTraceVisibilityMode.Default,
                "hidden" => ExperimentItemTraceVisibilityMode.Hidden,
                _ => null,
            };
        }
    }
}