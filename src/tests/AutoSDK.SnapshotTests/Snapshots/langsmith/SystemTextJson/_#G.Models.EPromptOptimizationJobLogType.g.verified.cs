//HintName: G.Models.EPromptOptimizationJobLogType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EPromptOptimizationJobLogType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Link,
        /// <summary>
        /// 
        /// </summary>
        Result,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EPromptOptimizationJobLogTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EPromptOptimizationJobLogType value)
        {
            return value switch
            {
                EPromptOptimizationJobLogType.Error => "error",
                EPromptOptimizationJobLogType.Info => "info",
                EPromptOptimizationJobLogType.Link => "link",
                EPromptOptimizationJobLogType.Result => "result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EPromptOptimizationJobLogType? ToEnum(string value)
        {
            return value switch
            {
                "error" => EPromptOptimizationJobLogType.Error,
                "info" => EPromptOptimizationJobLogType.Info,
                "link" => EPromptOptimizationJobLogType.Link,
                "result" => EPromptOptimizationJobLogType.Result,
                _ => null,
            };
        }
    }
}