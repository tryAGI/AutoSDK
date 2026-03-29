//HintName: G.Models.LlmAsJudgeMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlmAsJudgeMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        ToolExecutionResult,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlmAsJudgeMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmAsJudgeMessageRole value)
        {
            return value switch
            {
                LlmAsJudgeMessageRole.Ai => "AI",
                LlmAsJudgeMessageRole.Custom => "CUSTOM",
                LlmAsJudgeMessageRole.System => "SYSTEM",
                LlmAsJudgeMessageRole.ToolExecutionResult => "TOOL_EXECUTION_RESULT",
                LlmAsJudgeMessageRole.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmAsJudgeMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "AI" => LlmAsJudgeMessageRole.Ai,
                "CUSTOM" => LlmAsJudgeMessageRole.Custom,
                "SYSTEM" => LlmAsJudgeMessageRole.System,
                "TOOL_EXECUTION_RESULT" => LlmAsJudgeMessageRole.ToolExecutionResult,
                "USER" => LlmAsJudgeMessageRole.User,
                _ => null,
            };
        }
    }
}