//HintName: G.Models.LlmAsJudgeMessagePublicRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlmAsJudgeMessagePublicRole
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
    public static class LlmAsJudgeMessagePublicRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmAsJudgeMessagePublicRole value)
        {
            return value switch
            {
                LlmAsJudgeMessagePublicRole.Ai => "AI",
                LlmAsJudgeMessagePublicRole.Custom => "CUSTOM",
                LlmAsJudgeMessagePublicRole.System => "SYSTEM",
                LlmAsJudgeMessagePublicRole.ToolExecutionResult => "TOOL_EXECUTION_RESULT",
                LlmAsJudgeMessagePublicRole.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmAsJudgeMessagePublicRole? ToEnum(string value)
        {
            return value switch
            {
                "AI" => LlmAsJudgeMessagePublicRole.Ai,
                "CUSTOM" => LlmAsJudgeMessagePublicRole.Custom,
                "SYSTEM" => LlmAsJudgeMessagePublicRole.System,
                "TOOL_EXECUTION_RESULT" => LlmAsJudgeMessagePublicRole.ToolExecutionResult,
                "USER" => LlmAsJudgeMessagePublicRole.User,
                _ => null,
            };
        }
    }
}