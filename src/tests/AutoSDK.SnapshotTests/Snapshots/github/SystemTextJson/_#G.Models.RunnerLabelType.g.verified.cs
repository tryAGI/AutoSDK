//HintName: G.Models.RunnerLabelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of label. Read-only labels are applied automatically when the runner is configured.
    /// </summary>
    public enum RunnerLabelType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        ReadOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunnerLabelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunnerLabelType value)
        {
            return value switch
            {
                RunnerLabelType.Custom => "custom",
                RunnerLabelType.ReadOnly => "read-only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunnerLabelType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => RunnerLabelType.Custom,
                "read-only" => RunnerLabelType.ReadOnly,
                _ => null,
            };
        }
    }
}