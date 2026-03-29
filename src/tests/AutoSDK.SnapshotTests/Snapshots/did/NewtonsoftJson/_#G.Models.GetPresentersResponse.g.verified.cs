//HintName: G.Models.GetPresentersResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPresentersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presenters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetPresentersResponsePresenter> Presenters { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="GetPresentersResponse" /> class.
        /// </summary>
        /// <param name="presenters"></param>
        /// <param name="token"></param>
        public GetPresentersResponse(
            global::System.Collections.Generic.IList<global::G.GetPresentersResponsePresenter> presenters,
            string? token)
        {
            this.Presenters = presenters ?? throw new global::System.ArgumentNullException(nameof(presenters));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPresentersResponse" /> class.
        /// </summary>
        public GetPresentersResponse()
        {
        }
    }
}