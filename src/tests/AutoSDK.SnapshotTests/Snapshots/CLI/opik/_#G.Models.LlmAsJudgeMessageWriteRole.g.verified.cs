//HintName: G.Models.LlmAsJudgeMessageWriteRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlmAsJudgeMessageWriteRole
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
    public static class LlmAsJudgeMessageWriteRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmAsJudgeMessageWriteRole value)
        {
            return value switch
            {
                LlmAsJudgeMessageWriteRole.Ai => "AI",
                LlmAsJudgeMessageWriteRole.Custom => "CUSTOM",
                LlmAsJudgeMessageWriteRole.System => "SYSTEM",
                LlmAsJudgeMessageWriteRole.ToolExecutionResult => "TOOL_EXECUTION_RESULT",
                LlmAsJudgeMessageWriteRole.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmAsJudgeMessageWriteRole? ToEnum(string value)
        {
            return value switch
            {
                "AI" => LlmAsJudgeMessageWriteRole.Ai,
                "CUSTOM" => LlmAsJudgeMessageWriteRole.Custom,
                "SYSTEM" => LlmAsJudgeMessageWriteRole.System,
                "TOOL_EXECUTION_RESULT" => LlmAsJudgeMessageWriteRole.ToolExecutionResult,
                "USER" => LlmAsJudgeMessageWriteRole.User,
                _ => null,
            };
        }
    }
}