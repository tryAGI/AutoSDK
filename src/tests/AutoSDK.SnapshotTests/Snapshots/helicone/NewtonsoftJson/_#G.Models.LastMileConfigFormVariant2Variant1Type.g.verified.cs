//HintName: G.Models.LastMileConfigFormVariant2Variant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LastMileConfigFormVariant2Variant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="context_relevance")]
        ContextRelevance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="relevance")]
        Relevance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LastMileConfigFormVariant2Variant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LastMileConfigFormVariant2Variant1Type value)
        {
            return value switch
            {
                LastMileConfigFormVariant2Variant1Type.ContextRelevance => "context_relevance",
                LastMileConfigFormVariant2Variant1Type.Relevance => "relevance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LastMileConfigFormVariant2Variant1Type? ToEnum(string value)
        {
            return value switch
            {
                "context_relevance" => LastMileConfigFormVariant2Variant1Type.ContextRelevance,
                "relevance" => LastMileConfigFormVariant2Variant1Type.Relevance,
                _ => null,
            };
        }
    }
}