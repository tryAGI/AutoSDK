//HintName: G.Models.Rerankv2Response.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Rerankv2Response
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// An ordered list of ranked documents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Rerankv2ResponseResult> Results { get; set; }

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
        /// Initializes a new instance of the <see cref="Rerankv2Response" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="results">
        /// An ordered list of ranked documents
        /// </param>
        /// <param name="meta"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Rerankv2Response(
            global::System.Collections.Generic.IList<global::G.Rerankv2ResponseResult> results,
            string? id,
            global::G.ApiMeta? meta)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Id = id;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rerankv2Response" /> class.
        /// </summary>
        public Rerankv2Response()
        {
        }
    }
}