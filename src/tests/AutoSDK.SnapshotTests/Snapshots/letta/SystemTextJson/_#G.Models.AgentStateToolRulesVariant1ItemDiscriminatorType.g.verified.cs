//HintName: G.Models.AgentStateToolRulesVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentStateToolRulesVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Conditional,
        /// <summary>
        /// 
        /// </summary>
        ConstrainChildTools,
        /// <summary>
        /// 
        /// </summary>
        ContinueLoop,
        /// <summary>
        /// 
        /// </summary>
        ExitLoop,
        /// <summary>
        /// 
        /// </summary>
        MaxCountPerStep,
        /// <summary>
        /// 
        /// </summary>
        ParentLastTool,
        /// <summary>
        /// 
        /// </summary>
        RequiredBeforeExit,
        /// <summary>
        /// 
        /// </summary>
        RequiresApproval,
        /// <summary>
        /// 
        /// </summary>
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