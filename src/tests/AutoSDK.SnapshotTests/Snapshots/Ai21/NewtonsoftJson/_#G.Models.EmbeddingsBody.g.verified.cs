//HintName: G.Models.EmbeddingsBody.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// This class is to be used as a common class to all Studio API requests payloads
    /// </summary>
    public sealed partial class EmbeddingsBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("texts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Texts { get; set; } = default!;

        /// <summary>
        /// Default Value: segment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AllOf<global::G.EmbedType?>? Type { get; set; } = global::G.EmbedType.Segment;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}