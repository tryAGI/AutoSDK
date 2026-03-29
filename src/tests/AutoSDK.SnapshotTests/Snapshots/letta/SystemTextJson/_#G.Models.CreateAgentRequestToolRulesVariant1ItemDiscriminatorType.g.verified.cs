//HintName: G.Models.CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAgentRequestToolRulesVariant1ItemDiscriminatorType
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
    public static class CreateAgentRequestToolRulesVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentRequestToolRulesVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.Conditional => "conditional",
                CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.ConstrainChildTools => "constrain_child_tools",
                CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.ContinueLoop => "continue_loop",
                CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.ExitLoop => "exit_loop",
                CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.MaxCountPerStep => "max_count_per_step",
                CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.ParentLastTool => "parent_last_tool",
                CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.RequiredBeforeExit => "required_before_exit",
                CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.RequiresApproval => "requires_approval",
                CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.RunFirst => "run_first",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentRequestToolRulesVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "conditional" => CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.Conditional,
                "constrain_child_tools" => CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.ConstrainChildTools,
                "continue_loop" => CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.ContinueLoop,
                "exit_loop" => CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.ExitLoop,
                "max_count_per_step" => CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.MaxCountPerStep,
                "parent_last_tool" => CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.ParentLastTool,
                "required_before_exit" => CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.RequiredBeforeExit,
                "requires_approval" => CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.RequiresApproval,
                "run_first" => CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.RunFirst,
                _ => null,
            };
        }
    }
}