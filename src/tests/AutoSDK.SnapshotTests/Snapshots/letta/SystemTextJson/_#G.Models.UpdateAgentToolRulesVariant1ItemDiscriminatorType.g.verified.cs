//HintName: G.Models.UpdateAgentToolRulesVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAgentToolRulesVariant1ItemDiscriminatorType
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
    public static class UpdateAgentToolRulesVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAgentToolRulesVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                UpdateAgentToolRulesVariant1ItemDiscriminatorType.Conditional => "conditional",
                UpdateAgentToolRulesVariant1ItemDiscriminatorType.ConstrainChildTools => "constrain_child_tools",
                UpdateAgentToolRulesVariant1ItemDiscriminatorType.ContinueLoop => "continue_loop",
                UpdateAgentToolRulesVariant1ItemDiscriminatorType.ExitLoop => "exit_loop",
                UpdateAgentToolRulesVariant1ItemDiscriminatorType.MaxCountPerStep => "max_count_per_step",
                UpdateAgentToolRulesVariant1ItemDiscriminatorType.ParentLastTool => "parent_last_tool",
                UpdateAgentToolRulesVariant1ItemDiscriminatorType.RequiredBeforeExit => "required_before_exit",
                UpdateAgentToolRulesVariant1ItemDiscriminatorType.RequiresApproval => "requires_approval",
                UpdateAgentToolRulesVariant1ItemDiscriminatorType.RunFirst => "run_first",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAgentToolRulesVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "conditional" => UpdateAgentToolRulesVariant1ItemDiscriminatorType.Conditional,
                "constrain_child_tools" => UpdateAgentToolRulesVariant1ItemDiscriminatorType.ConstrainChildTools,
                "continue_loop" => UpdateAgentToolRulesVariant1ItemDiscriminatorType.ContinueLoop,
                "exit_loop" => UpdateAgentToolRulesVariant1ItemDiscriminatorType.ExitLoop,
                "max_count_per_step" => UpdateAgentToolRulesVariant1ItemDiscriminatorType.MaxCountPerStep,
                "parent_last_tool" => UpdateAgentToolRulesVariant1ItemDiscriminatorType.ParentLastTool,
                "required_before_exit" => UpdateAgentToolRulesVariant1ItemDiscriminatorType.RequiredBeforeExit,
                "requires_approval" => UpdateAgentToolRulesVariant1ItemDiscriminatorType.RequiresApproval,
                "run_first" => UpdateAgentToolRulesVariant1ItemDiscriminatorType.RunFirst,
                _ => null,
            };
        }
    }
}