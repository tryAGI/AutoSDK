//HintName: G.Models.GetTalksResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTalksResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("talks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetTalksResponseTalk> Talks { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTalksResponse" /> class.
        /// </summary>
        /// <param name="talks"></param>
        /// <param name="token"></param>
        public GetTalksResponse(
            global::System.Collections.Generic.IList<global::G.GetTalksResponseTalk> talks,
            string? token)
        {
            this.Talks = talks ?? throw new global::System.ArgumentNullException(nameof(talks));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTalksResponse" /> class.
        /// </summary>
        public GetTalksResponse()
        {
        }
    }
}