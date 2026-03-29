//HintName: G.Models.AgentConfigValuePublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentConfigValuePublicType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="boolean")]
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float")]
        Float,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="integer")]
        Integer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt_commit")]
        PromptCommit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string")]
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