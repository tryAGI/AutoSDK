//HintName: G.Models.GetClipsDriversResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetClipsDriversResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clips_drivers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetClipsDriversResponseClipsDriver> ClipsDrivers { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="GetClipsDriversResponse" /> class.
        /// </summary>
        /// <param name="clipsDrivers"></param>
        /// <param name="token"></param>
        public GetClipsDriversResponse(
            global::System.Collections.Generic.IList<global::G.GetClipsDriversResponseClipsDriver> clipsDrivers,
            string? token)
        {
            this.ClipsDrivers = clipsDrivers ?? throw new global::System.ArgumentNullException(nameof(clipsDrivers));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClipsDriversResponse" /> class.
        /// </summary>
        public GetClipsDriversResponse()
        {
        }
    }
}