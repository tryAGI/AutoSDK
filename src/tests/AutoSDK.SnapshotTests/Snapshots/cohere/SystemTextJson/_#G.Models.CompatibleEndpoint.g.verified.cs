//HintName: G.Models.CompatibleEndpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of the Cohere API endpoints that the model can be used with.
    /// </summary>
    public enum CompatibleEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Classify,
        /// <summary>
        /// 
        /// </summary>
        Embed,
        /// <summary>
        /// 
        /// </summary>
        Generate,
        /// <summary>
        /// 
        /// </summary>
        Rate,
        /// <summary>
        /// 
        /// </summary>
        Rerank,
        /// <summary>
        /// 
        /// </summary>
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