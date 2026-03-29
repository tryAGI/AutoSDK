//HintName: G.Models.GetClipsResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetClipsResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clips", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetClipsResponseClip2> Clips { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="GetClipsResponse2" /> class.
        /// </summary>
        /// <param name="clips"></param>
        /// <param name="token"></param>
        public GetClipsResponse2(
            global::System.Collections.Generic.IList<global::G.GetClipsResponseClip2> clips,
            string? token)
        {
            this.Clips = clips ?? throw new global::System.ArgumentNullException(nameof(clips));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClipsResponse2" /> class.
        /// </summary>
        public GetClipsResponse2()
        {
        }
    }
}