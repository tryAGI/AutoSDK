//HintName: G.Models.JwtResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JwtResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessToken", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccessToken { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aud", Required = global::Newtonsoft.Json.Required.Always)]
        public object Aud { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JwtResponse" /> class.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="aud"></param>
        public JwtResponse(
            string accessToken,
            object aud)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.Aud = aud ?? throw new global::System.ArgumentNullException(nameof(aud));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JwtResponse" /> class.
        /// </summary>
        public JwtResponse()
        {
        }
    }
}