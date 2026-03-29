//HintName: G.Models.GetAnimationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnimationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("animations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetAnimationsResponseAnimation> Animations { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="GetAnimationsResponse" /> class.
        /// </summary>
        /// <param name="animations"></param>
        /// <param name="token"></param>
        public GetAnimationsResponse(
            global::System.Collections.Generic.IList<global::G.GetAnimationsResponseAnimation> animations,
            string? token)
        {
            this.Animations = animations ?? throw new global::System.ArgumentNullException(nameof(animations));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnimationsResponse" /> class.
        /// </summary>
        public GetAnimationsResponse()
        {
        }
    }
}