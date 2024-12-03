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
        Embed,
        /// <summary>
        /// 
        /// </summary>
        Classify,
        /// <summary>
        /// 
        /// </summary>
        Summarize,
        /// <summary>
        /// 
        /// </summary>
        Rerank,
        /// <summary>
        /// 
        /// </summary>
        Rate,
        /// <summary>
        /// 
        /// </summary>
        Generate,
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
                CompatibleEndpoint.Embed => "embed",
                CompatibleEndpoint.Classify => "classify",
                CompatibleEndpoint.Summarize => "summarize",
                CompatibleEndpoint.Rerank => "rerank",
                CompatibleEndpoint.Rate => "rate",
                CompatibleEndpoint.Generate => "generate",
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
                "embed" => CompatibleEndpoint.Embed,
                "classify" => CompatibleEndpoint.Classify,
                "summarize" => CompatibleEndpoint.Summarize,
                "rerank" => CompatibleEndpoint.Rerank,
                "rate" => CompatibleEndpoint.Rate,
                "generate" => CompatibleEndpoint.Generate,
                _ => null,
            };
        }
    }
}