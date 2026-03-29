//HintName: G.Models.ReasoningMessageSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: non_reasoner_model
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReasoningMessageSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="non_reasoner_model")]
        NonReasonerModel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reasoner_model")]
        ReasonerModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningMessageSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningMessageSource value)
        {
            return value switch
            {
                ReasoningMessageSource.NonReasonerModel => "non_reasoner_model",
                ReasoningMessageSource.ReasonerModel => "reasoner_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningMessageSource? ToEnum(string value)
        {
            return value switch
            {
                "non_reasoner_model" => ReasoningMessageSource.NonReasonerModel,
                "reasoner_model" => ReasoningMessageSource.ReasonerModel,
                _ => null,
            };
        }
    }
}