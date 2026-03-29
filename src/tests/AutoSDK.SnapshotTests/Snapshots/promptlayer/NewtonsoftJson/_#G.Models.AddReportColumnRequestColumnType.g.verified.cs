//HintName: G.Models.AddReportColumnRequestColumnType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of evaluation or transformation this column performs. Must be one of the supported column types.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AddReportColumnRequestColumnType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ABSOLUTE_NUMERIC_DISTANCE")]
        AbsoluteNumericDistance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AI_DATA_EXTRACTION")]
        AiDataExtraction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="APPLY_DIFF")]
        ApplyDiff,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASSERT_VALID")]
        AssertValid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COALESCE")]
        Coalesce,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CODE_EXECUTION")]
        CodeExecution,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CODING_AGENT")]
        CodingAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMBINE_COLUMNS")]
        CombineColumns,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPARE")]
        Compare,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONTAINS")]
        Contains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONVERSATION_SIMULATOR")]
        ConversationSimulator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COSINE_SIMILARITY")]
        CosineSimilarity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COUNT")]
        Count,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ENDPOINT")]
        Endpoint,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HUMAN")]
        Human,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="JSON_PATH")]
        JsonPath,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LLM_ASSERTION")]
        LlmAssertion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MATH_OPERATOR")]
        MathOperator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MCP")]
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MIN_MAX")]
        MinMax,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PARSE_VALUE")]
        ParseValue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROMPT_TEMPLATE")]
        PromptTemplate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="REGEX")]
        Regex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="REGEX_EXTRACTION")]
        RegexExtraction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VARIABLE")]
        Variable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="WORKFLOW")]
        Workflow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="XML_PATH")]
        XmlPath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddReportColumnRequestColumnTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddReportColumnRequestColumnType value)
        {
            return value switch
            {
                AddReportColumnRequestColumnType.AbsoluteNumericDistance => "ABSOLUTE_NUMERIC_DISTANCE",
                AddReportColumnRequestColumnType.AiDataExtraction => "AI_DATA_EXTRACTION",
                AddReportColumnRequestColumnType.ApplyDiff => "APPLY_DIFF",
                AddReportColumnRequestColumnType.AssertValid => "ASSERT_VALID",
                AddReportColumnRequestColumnType.Coalesce => "COALESCE",
                AddReportColumnRequestColumnType.CodeExecution => "CODE_EXECUTION",
                AddReportColumnRequestColumnType.CodingAgent => "CODING_AGENT",
                AddReportColumnRequestColumnType.CombineColumns => "COMBINE_COLUMNS",
                AddReportColumnRequestColumnType.Compare => "COMPARE",
                AddReportColumnRequestColumnType.Contains => "CONTAINS",
                AddReportColumnRequestColumnType.ConversationSimulator => "CONVERSATION_SIMULATOR",
                AddReportColumnRequestColumnType.CosineSimilarity => "COSINE_SIMILARITY",
                AddReportColumnRequestColumnType.Count => "COUNT",
                AddReportColumnRequestColumnType.Endpoint => "ENDPOINT",
                AddReportColumnRequestColumnType.Human => "HUMAN",
                AddReportColumnRequestColumnType.JsonPath => "JSON_PATH",
                AddReportColumnRequestColumnType.LlmAssertion => "LLM_ASSERTION",
                AddReportColumnRequestColumnType.MathOperator => "MATH_OPERATOR",
                AddReportColumnRequestColumnType.Mcp => "MCP",
                AddReportColumnRequestColumnType.MinMax => "MIN_MAX",
                AddReportColumnRequestColumnType.ParseValue => "PARSE_VALUE",
                AddReportColumnRequestColumnType.PromptTemplate => "PROMPT_TEMPLATE",
                AddReportColumnRequestColumnType.Regex => "REGEX",
                AddReportColumnRequestColumnType.RegexExtraction => "REGEX_EXTRACTION",
                AddReportColumnRequestColumnType.Variable => "VARIABLE",
                AddReportColumnRequestColumnType.Workflow => "WORKFLOW",
                AddReportColumnRequestColumnType.XmlPath => "XML_PATH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddReportColumnRequestColumnType? ToEnum(string value)
        {
            return value switch
            {
                "ABSOLUTE_NUMERIC_DISTANCE" => AddReportColumnRequestColumnType.AbsoluteNumericDistance,
                "AI_DATA_EXTRACTION" => AddReportColumnRequestColumnType.AiDataExtraction,
                "APPLY_DIFF" => AddReportColumnRequestColumnType.ApplyDiff,
                "ASSERT_VALID" => AddReportColumnRequestColumnType.AssertValid,
                "COALESCE" => AddReportColumnRequestColumnType.Coalesce,
                "CODE_EXECUTION" => AddReportColumnRequestColumnType.CodeExecution,
                "CODING_AGENT" => AddReportColumnRequestColumnType.CodingAgent,
                "COMBINE_COLUMNS" => AddReportColumnRequestColumnType.CombineColumns,
                "COMPARE" => AddReportColumnRequestColumnType.Compare,
                "CONTAINS" => AddReportColumnRequestColumnType.Contains,
                "CONVERSATION_SIMULATOR" => AddReportColumnRequestColumnType.ConversationSimulator,
                "COSINE_SIMILARITY" => AddReportColumnRequestColumnType.CosineSimilarity,
                "COUNT" => AddReportColumnRequestColumnType.Count,
                "ENDPOINT" => AddReportColumnRequestColumnType.Endpoint,
                "HUMAN" => AddReportColumnRequestColumnType.Human,
                "JSON_PATH" => AddReportColumnRequestColumnType.JsonPath,
                "LLM_ASSERTION" => AddReportColumnRequestColumnType.LlmAssertion,
                "MATH_OPERATOR" => AddReportColumnRequestColumnType.MathOperator,
                "MCP" => AddReportColumnRequestColumnType.Mcp,
                "MIN_MAX" => AddReportColumnRequestColumnType.MinMax,
                "PARSE_VALUE" => AddReportColumnRequestColumnType.ParseValue,
                "PROMPT_TEMPLATE" => AddReportColumnRequestColumnType.PromptTemplate,
                "REGEX" => AddReportColumnRequestColumnType.Regex,
                "REGEX_EXTRACTION" => AddReportColumnRequestColumnType.RegexExtraction,
                "VARIABLE" => AddReportColumnRequestColumnType.Variable,
                "WORKFLOW" => AddReportColumnRequestColumnType.Workflow,
                "XML_PATH" => AddReportColumnRequestColumnType.XmlPath,
                _ => null,
            };
        }
    }
}