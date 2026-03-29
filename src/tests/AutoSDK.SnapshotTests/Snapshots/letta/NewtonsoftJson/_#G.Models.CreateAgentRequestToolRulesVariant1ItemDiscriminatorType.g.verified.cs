//HintName: G.Models.CreateAgentRequestToolRulesVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAgentRequestToolRulesVariant1ItemDiscriminatorType
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