//HintName: G.Models.AddReportColumnRequestColumnType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of evaluation or transformation this column performs. Must be one of the supported column types.
    /// </summary>
    public enum AddReportColumnRequestColumnType
    {
        /// <summary>
        /// 
        /// </summary>
        AbsoluteNumericDistance,
        /// <summary>
        /// 
        /// </summary>
        AiDataExtraction,
        /// <summary>
        /// 
        /// </summary>
        ApplyDiff,
        /// <summary>
        /// 
        /// </summary>
        AssertValid,
        /// <summary>
        /// 
        /// </summary>
        Coalesce,
        /// <summary>
        /// 
        /// </summary>
        CodeExecution,
        /// <summary>
        /// 
        /// </summary>
        CodingAgent,
        /// <summary>
        /// 
        /// </summary>
        CombineColumns,
        /// <summary>
        /// 
        /// </summary>
        Compare,
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        ConversationSimulator,
        /// <summary>
        /// 
        /// </summary>
        CosineSimilarity,
        /// <summary>
        /// 
        /// </summary>
        Count,
        /// <summary>
        /// 
        /// </summary>
        Endpoint,
        /// <summary>
        /// 
        /// </summary>
        Human,
        /// <summary>
        /// 
        /// </summary>
        JsonPath,
        /// <summary>
        /// 
        /// </summary>
        LlmAssertion,
        /// <summary>
        /// 
        /// </summary>
        MathOperator,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        MinMax,
        /// <summary>
        /// 
        /// </summary>
        ParseValue,
        /// <summary>
        /// 
        /// </summary>
        PromptTemplate,
        /// <summary>
        /// 
        /// </summary>
        Regex,
        /// <summary>
        /// 
        /// </summary>
        RegexExtraction,
        /// <summary>
        /// 
        /// </summary>
        Variable,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
        /// <summary>
        /// 
        /// </summary>
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