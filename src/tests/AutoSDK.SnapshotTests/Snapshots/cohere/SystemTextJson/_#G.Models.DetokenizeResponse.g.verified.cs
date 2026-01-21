//HintName: G.Models.DetokenizeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetokenizeResponse
    {
        /// <summary>
        /// A string representing the list of tokens.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetokenizeResponse" /> class.
        /// </summary>
        /// <param name="text">
        /// A string representing the list of tokens.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetokenizeResponse(
            global::G.ApiMeta? meta,
            string text = default!)
        {
            this.Text = text;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetokenizeResponse" /> class.
        /// </summary>
        public DetokenizeResponse()
        {
        }
    }
}