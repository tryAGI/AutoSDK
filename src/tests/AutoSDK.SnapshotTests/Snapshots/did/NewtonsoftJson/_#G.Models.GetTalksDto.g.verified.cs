//HintName: G.Models.GetTalksDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTalksDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("talks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetTalksDtoTalk> Talks { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="GetTalksDto" /> class.
        /// </summary>
        /// <param name="talks"></param>
        /// <param name="token"></param>
        public GetTalksDto(
            global::System.Collections.Generic.IList<global::G.GetTalksDtoTalk> talks,
            string? token)
        {
            this.Talks = talks ?? throw new global::System.ArgumentNullException(nameof(talks));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTalksDto" /> class.
        /// </summary>
        public GetTalksDto()
        {
        }
    }
}