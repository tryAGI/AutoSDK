//HintName: G.Models.StreamGenerationEnd.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The end of generation. There may still be more information such as the<br/>
    /// factual consistency score, but generation has stopped.
    /// </summary>
    public sealed partial class StreamGenerationEnd
    {
        /// <summary>
        /// Then end of generation will be denoted with an object<br/>
        /// with the type `generation_end`.<br/>
        /// Default Value: generation_end
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; } = "generation_end";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}