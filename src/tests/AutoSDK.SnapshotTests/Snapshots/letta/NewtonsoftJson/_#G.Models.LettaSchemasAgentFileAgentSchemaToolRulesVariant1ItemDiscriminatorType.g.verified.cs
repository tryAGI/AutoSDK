//HintName: G.Models.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType
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
    public static class LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.Conditional => "conditional",
                LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.ConstrainChildTools => "constrain_child_tools",
                LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.ContinueLoop => "continue_loop",
                LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.ExitLoop => "exit_loop",
                LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.MaxCountPerStep => "max_count_per_step",
                LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.ParentLastTool => "parent_last_tool",
                LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.RequiredBeforeExit => "required_before_exit",
                LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.RequiresApproval => "requires_approval",
                LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.RunFirst => "run_first",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "conditional" => LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.Conditional,
                "constrain_child_tools" => LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.ConstrainChildTools,
                "continue_loop" => LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.ContinueLoop,
                "exit_loop" => LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.ExitLoop,
                "max_count_per_step" => LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.MaxCountPerStep,
                "parent_last_tool" => LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.ParentLastTool,
                "required_before_exit" => LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.RequiredBeforeExit,
                "requires_approval" => LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.RequiresApproval,
                "run_first" => LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.RunFirst,
                _ => null,
            };
        }
    }
}