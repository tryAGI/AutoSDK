//HintName: G.Models.RealtimeSessionTurnDetectionEagerness.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Used only for `semantic_vad` mode. The eagerness of the model to respond. `low` will wait longer for the user to continue speaking, `high` will respond more quickly. `auto` is the default and is equivalent to `medium`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeSessionTurnDetectionEagerness
    {
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionTurnDetectionEagernessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionTurnDetectionEagerness value)
        {
            return value switch
            {
                RealtimeSessionTurnDetectionEagerness.Low => "low",
                RealtimeSessionTurnDetectionEagerness.Medium => "medium",
                RealtimeSessionTurnDetectionEagerness.High => "high",
                RealtimeSessionTurnDetectionEagerness.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionTurnDetectionEagerness? ToEnum(string value)
        {
            return value switch
            {
                "low" => RealtimeSessionTurnDetectionEagerness.Low,
                "medium" => RealtimeSessionTurnDetectionEagerness.Medium,
                "high" => RealtimeSessionTurnDetectionEagerness.High,
                "auto" => RealtimeSessionTurnDetectionEagerness.Auto,
                _ => null,
            };
        }
    }
}