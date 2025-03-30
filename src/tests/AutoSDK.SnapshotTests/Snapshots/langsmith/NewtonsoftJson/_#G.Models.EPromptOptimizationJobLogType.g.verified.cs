//HintName: G.Models.EPromptOptimizationJobLogType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EPromptOptimizationJobLogType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="info")]
        Info,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="result")]
        Result,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="link")]
        Link,
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
                EPromptOptimizationJobLogType.Info => "info",
                EPromptOptimizationJobLogType.Result => "result",
                EPromptOptimizationJobLogType.Error => "error",
                EPromptOptimizationJobLogType.Link => "link",
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
                "info" => EPromptOptimizationJobLogType.Info,
                "result" => EPromptOptimizationJobLogType.Result,
                "error" => EPromptOptimizationJobLogType.Error,
                "link" => EPromptOptimizationJobLogType.Link,
                _ => null,
            };
        }
    }
}