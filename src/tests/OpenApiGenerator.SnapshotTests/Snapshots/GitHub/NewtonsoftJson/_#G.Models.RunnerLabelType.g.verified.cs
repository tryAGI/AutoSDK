//HintName: G.Models.RunnerLabelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of label. Read-only labels are applied automatically when the runner is configured.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunnerLabelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read-only")]
        ReadOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom")]
        Custom,
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
                RunnerLabelType.ReadOnly => "read-only",
                RunnerLabelType.Custom => "custom",
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
                "read-only" => RunnerLabelType.ReadOnly,
                "custom" => RunnerLabelType.Custom,
                _ => null,
            };
        }
    }
}