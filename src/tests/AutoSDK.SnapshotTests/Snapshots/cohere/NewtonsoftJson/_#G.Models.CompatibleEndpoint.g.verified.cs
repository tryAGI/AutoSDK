//HintName: G.Models.CompatibleEndpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of the Cohere API endpoints that the model can be used with.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompatibleEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat")]
        Chat,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="classify")]
        Classify,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embed")]
        Embed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generate")]
        Generate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rate")]
        Rate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rerank")]
        Rerank,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="summarize")]
        Summarize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompatibleEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompatibleEndpoint value)
        {
            return value switch
            {
                CompatibleEndpoint.Chat => "chat",
                CompatibleEndpoint.Classify => "classify",
                CompatibleEndpoint.Embed => "embed",
                CompatibleEndpoint.Generate => "generate",
                CompatibleEndpoint.Rate => "rate",
                CompatibleEndpoint.Rerank => "rerank",
                CompatibleEndpoint.Summarize => "summarize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompatibleEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "chat" => CompatibleEndpoint.Chat,
                "classify" => CompatibleEndpoint.Classify,
                "embed" => CompatibleEndpoint.Embed,
                "generate" => CompatibleEndpoint.Generate,
                "rate" => CompatibleEndpoint.Rate,
                "rerank" => CompatibleEndpoint.Rerank,
                "summarize" => CompatibleEndpoint.Summarize,
                _ => null,
            };
        }
    }
}