//HintName: G.Models.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType
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
    public static class InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.Conditional => "conditional",
                InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.ConstrainChildTools => "constrain_child_tools",
                InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.ContinueLoop => "continue_loop",
                InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.ExitLoop => "exit_loop",
                InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.MaxCountPerStep => "max_count_per_step",
                InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.ParentLastTool => "parent_last_tool",
                InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.RequiredBeforeExit => "required_before_exit",
                InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.RequiresApproval => "requires_approval",
                InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.RunFirst => "run_first",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "conditional" => InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.Conditional,
                "constrain_child_tools" => InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.ConstrainChildTools,
                "continue_loop" => InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.ContinueLoop,
                "exit_loop" => InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.ExitLoop,
                "max_count_per_step" => InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.MaxCountPerStep,
                "parent_last_tool" => InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.ParentLastTool,
                "required_before_exit" => InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.RequiredBeforeExit,
                "requires_approval" => InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.RequiresApproval,
                "run_first" => InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType.RunFirst,
                _ => null,
            };
        }
    }
}