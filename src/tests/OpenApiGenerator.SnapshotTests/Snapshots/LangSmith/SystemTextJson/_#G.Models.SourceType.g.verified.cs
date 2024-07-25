//HintName: G.Models.SourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for feedback source types.
    /// </summary>
    public enum SourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        AutoEval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SourceType value)
        {
            return value switch
            {
                SourceType.Api => "api",
                SourceType.Model => "model",
                SourceType.App => "app",
                SourceType.AutoEval => "auto_eval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SourceType? ToEnum(string value)
        {
            return value switch
            {
                "api" => SourceType.Api,
                "model" => SourceType.Model,
                "app" => SourceType.App,
                "auto_eval" => SourceType.AutoEval,
                _ => null,
            };
        }
    }
}