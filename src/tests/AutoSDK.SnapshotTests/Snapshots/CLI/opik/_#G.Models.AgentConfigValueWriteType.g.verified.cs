//HintName: G.Models.AgentConfigValueWriteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentConfigValueWriteType
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
    public static class AgentConfigValueWriteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConfigValueWriteType value)
        {
            return value switch
            {
                AgentConfigValueWriteType.Boolean => "boolean",
                AgentConfigValueWriteType.Float => "float",
                AgentConfigValueWriteType.Integer => "integer",
                AgentConfigValueWriteType.Prompt => "prompt",
                AgentConfigValueWriteType.PromptCommit => "prompt_commit",
                AgentConfigValueWriteType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConfigValueWriteType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AgentConfigValueWriteType.Boolean,
                "float" => AgentConfigValueWriteType.Float,
                "integer" => AgentConfigValueWriteType.Integer,
                "prompt" => AgentConfigValueWriteType.Prompt,
                "prompt_commit" => AgentConfigValueWriteType.PromptCommit,
                "string" => AgentConfigValueWriteType.String,
                _ => null,
            };
        }
    }
}