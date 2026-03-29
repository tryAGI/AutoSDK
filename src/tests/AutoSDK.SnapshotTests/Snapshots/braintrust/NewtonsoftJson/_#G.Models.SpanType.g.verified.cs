//HintName: G.Models.SpanType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the span, for display purposes only
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpanType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automation")]
        Automation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="classifier")]
        Classifier,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eval")]
        Eval,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="facet")]
        Facet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="preprocessor")]
        Preprocessor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="review")]
        Review,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="score")]
        Score,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="task")]
        Task,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanType value)
        {
            return value switch
            {
                SpanType.Automation => "automation",
                SpanType.Classifier => "classifier",
                SpanType.Eval => "eval",
                SpanType.Facet => "facet",
                SpanType.Function => "function",
                SpanType.Llm => "llm",
                SpanType.Preprocessor => "preprocessor",
                SpanType.Review => "review",
                SpanType.Score => "score",
                SpanType.Task => "task",
                SpanType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanType? ToEnum(string value)
        {
            return value switch
            {
                "automation" => SpanType.Automation,
                "classifier" => SpanType.Classifier,
                "eval" => SpanType.Eval,
                "facet" => SpanType.Facet,
                "function" => SpanType.Function,
                "llm" => SpanType.Llm,
                "preprocessor" => SpanType.Preprocessor,
                "review" => SpanType.Review,
                "score" => SpanType.Score,
                "task" => SpanType.Task,
                "tool" => SpanType.Tool,
                _ => null,
            };
        }
    }
}