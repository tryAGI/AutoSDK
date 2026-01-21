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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// An ordered list of ranked documents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Rerankv2ResponseResult> Results { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Rerankv2Response" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="results">
        /// An ordered list of ranked documents
        /// </param>
        /// <param name="meta"></param>
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