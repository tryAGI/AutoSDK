//HintName: G.Models.GetClipsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetClipsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clips", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetClipsResponseClip> Clips { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="GetClipsResponse" /> class.
        /// </summary>
        /// <param name="clips"></param>
        /// <param name="token"></param>
        public GetClipsResponse(
            global::System.Collections.Generic.IList<global::G.GetClipsResponseClip> clips,
            string? token)
        {
            this.Clips = clips ?? throw new global::System.ArgumentNullException(nameof(clips));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClipsResponse" /> class.
        /// </summary>
        public GetClipsResponse()
        {
        }
    }
}