//HintName: G.Models.AgentConfigValueHistoryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentConfigValueHistoryType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Integer,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        PromptCommit,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentConfigValueHistoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConfigValueHistoryType value)
        {
            return value switch
            {
                AgentConfigValueHistoryType.Boolean => "boolean",
                AgentConfigValueHistoryType.Float => "float",
                AgentConfigValueHistoryType.Integer => "integer",
                AgentConfigValueHistoryType.Prompt => "prompt",
                AgentConfigValueHistoryType.PromptCommit => "prompt_commit",
                AgentConfigValueHistoryType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConfigValueHistoryType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AgentConfigValueHistoryType.Boolean,
                "float" => AgentConfigValueHistoryType.Float,
                "integer" => AgentConfigValueHistoryType.Integer,
                "prompt" => AgentConfigValueHistoryType.Prompt,
                "prompt_commit" => AgentConfigValueHistoryType.PromptCommit,
                "string" => AgentConfigValueHistoryType.String,
                _ => null,
            };
        }
    }
}