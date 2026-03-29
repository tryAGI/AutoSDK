//HintName: G.Models.AgentStateToolRulesVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentStateToolRulesVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conditional")]
        Conditional,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="constrain_child_tools")]
        ConstrainChildTools,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="continue_loop")]
        ContinueLoop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exit_loop")]
        ExitLoop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_count_per_step")]
        MaxCountPerStep,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parent_last_tool")]
        ParentLastTool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="required_before_exit")]
        RequiredBeforeExit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requires_approval")]
        RequiresApproval,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="run_first")]
        RunFirst,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentStateToolRulesVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentStateToolRulesVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                AgentStateToolRulesVariant1ItemDiscriminatorType.Conditional => "conditional",
                AgentStateToolRulesVariant1ItemDiscriminatorType.ConstrainChildTools => "constrain_child_tools",
                AgentStateToolRulesVariant1ItemDiscriminatorType.ContinueLoop => "continue_loop",
                AgentStateToolRulesVariant1ItemDiscriminatorType.ExitLoop => "exit_loop",
                AgentStateToolRulesVariant1ItemDiscriminatorType.MaxCountPerStep => "max_count_per_step",
                AgentStateToolRulesVariant1ItemDiscriminatorType.ParentLastTool => "parent_last_tool",
                AgentStateToolRulesVariant1ItemDiscriminatorType.RequiredBeforeExit => "required_before_exit",
                AgentStateToolRulesVariant1ItemDiscriminatorType.RequiresApproval => "requires_approval",
                AgentStateToolRulesVariant1ItemDiscriminatorType.RunFirst => "run_first",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentStateToolRulesVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "conditional" => AgentStateToolRulesVariant1ItemDiscriminatorType.Conditional,
                "constrain_child_tools" => AgentStateToolRulesVariant1ItemDiscriminatorType.ConstrainChildTools,
                "continue_loop" => AgentStateToolRulesVariant1ItemDiscriminatorType.ContinueLoop,
                "exit_loop" => AgentStateToolRulesVariant1ItemDiscriminatorType.ExitLoop,
                "max_count_per_step" => AgentStateToolRulesVariant1ItemDiscriminatorType.MaxCountPerStep,
                "parent_last_tool" => AgentStateToolRulesVariant1ItemDiscriminatorType.ParentLastTool,
                "required_before_exit" => AgentStateToolRulesVariant1ItemDiscriminatorType.RequiredBeforeExit,
                "requires_approval" => AgentStateToolRulesVariant1ItemDiscriminatorType.RequiresApproval,
                "run_first" => AgentStateToolRulesVariant1ItemDiscriminatorType.RunFirst,
                _ => null,
            };
        }
    }
}