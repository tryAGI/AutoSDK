//HintName: G.Models.UpdateApiAppOpenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateApiAppOpenRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiAppOpenRequest" /> class.
        /// </summary>
        /// <param name="callbackUrl"></param>
        /// <param name="name"></param>
        public UpdateApiAppOpenRequest(
            string? callbackUrl,
            string? name)
        {
            this.CallbackUrl = callbackUrl;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiAppOpenRequest" /> class.
        /// </summary>
        public UpdateApiAppOpenRequest()
        {
        }
    }
}