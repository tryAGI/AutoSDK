//HintName: G.Models.AgentConfigValuePublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentConfigValuePublicType
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
    public static class AgentConfigValuePublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConfigValuePublicType value)
        {
            return value switch
            {
                AgentConfigValuePublicType.Boolean => "boolean",
                AgentConfigValuePublicType.Float => "float",
                AgentConfigValuePublicType.Integer => "integer",
                AgentConfigValuePublicType.Prompt => "prompt",
                AgentConfigValuePublicType.PromptCommit => "prompt_commit",
                AgentConfigValuePublicType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConfigValuePublicType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => AgentConfigValuePublicType.Boolean,
                "float" => AgentConfigValuePublicType.Float,
                "integer" => AgentConfigValuePublicType.Integer,
                "prompt" => AgentConfigValuePublicType.Prompt,
                "prompt_commit" => AgentConfigValuePublicType.PromptCommit,
                "string" => AgentConfigValuePublicType.String,
                _ => null,
            };
        }
    }
}