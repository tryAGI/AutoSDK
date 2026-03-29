//HintName: G.Models.ObservationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservationType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        Chain,
        /// <summary>
        /// 
        /// </summary>
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        Evaluator,
        /// <summary>
        /// 
        /// </summary>
        Event,
        /// <summary>
        /// 
        /// </summary>
        Generation,
        /// <summary>
        /// 
        /// </summary>
        Guardrail,
        /// <summary>
        /// 
        /// </summary>
        Retriever,
        /// <summary>
        /// 
        /// </summary>
        Span,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservationType value)
        {
            return value switch
            {
                ObservationType.Agent => "AGENT",
                ObservationType.Chain => "CHAIN",
                ObservationType.Embedding => "EMBEDDING",
                ObservationType.Evaluator => "EVALUATOR",
                ObservationType.Event => "EVENT",
                ObservationType.Generation => "GENERATION",
                ObservationType.Guardrail => "GUARDRAIL",
                ObservationType.Retriever => "RETRIEVER",
                ObservationType.Span => "SPAN",
                ObservationType.Tool => "TOOL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservationType? ToEnum(string value)
        {
            return value switch
            {
                "AGENT" => ObservationType.Agent,
                "CHAIN" => ObservationType.Chain,
                "EMBEDDING" => ObservationType.Embedding,
                "EVALUATOR" => ObservationType.Evaluator,
                "EVENT" => ObservationType.Event,
                "GENERATION" => ObservationType.Generation,
                "GUARDRAIL" => ObservationType.Guardrail,
                "RETRIEVER" => ObservationType.Retriever,
                "SPAN" => ObservationType.Span,
                "TOOL" => ObservationType.Tool,
                _ => null,
            };
        }
    }
}