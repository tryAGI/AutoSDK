//HintName: G.Models.FineTuningJobEventLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuningJobEventLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warn,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    public static class FineTuningJobEventLevelExtensions
    {
        public static string ToValueString(this FineTuningJobEventLevel value)
        {
            return value switch
            {
                FineTuningJobEventLevel.Info => "info",
                FineTuningJobEventLevel.Warn => "warn",
                FineTuningJobEventLevel.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static FineTuningJobEventLevel ToEnum(string value)
        {
            return value switch
            {
                "info" => FineTuningJobEventLevel.Info,
                "warn" => FineTuningJobEventLevel.Warn,
                "error" => FineTuningJobEventLevel.Error,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static FineTuningJobEventLevel ToEnum(int value)
        {
            return value switch
            {
                0 => FineTuningJobEventLevel.Info,
                1 => FineTuningJobEventLevel.Warn,
                2 => FineTuningJobEventLevel.Error,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}