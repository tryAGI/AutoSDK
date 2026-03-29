//HintName: G.Models.GetScenesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetScenesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scenes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetScenesResponseScene> Scenes { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="GetScenesResponse" /> class.
        /// </summary>
        /// <param name="scenes"></param>
        /// <param name="token"></param>
        public GetScenesResponse(
            global::System.Collections.Generic.IList<global::G.GetScenesResponseScene> scenes,
            string? token)
        {
            this.Scenes = scenes ?? throw new global::System.ArgumentNullException(nameof(scenes));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScenesResponse" /> class.
        /// </summary>
        public GetScenesResponse()
        {
        }
    }
}