//HintName: G.Models.ObservationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ObservationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AGENT")]
        Agent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CHAIN")]
        Chain,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EMBEDDING")]
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EVALUATOR")]
        Evaluator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EVENT")]
        Event,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GENERATION")]
        Generation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GUARDRAIL")]
        Guardrail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RETRIEVER")]
        Retriever,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SPAN")]
        Span,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TOOL")]
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