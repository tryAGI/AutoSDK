//HintName: G.Models.RequestObj.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestObj
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestObj" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="provider"></param>
        public RequestObj(
            string id,
            string provider)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestObj" /> class.
        /// </summary>
        public RequestObj()
        {
        }
    }
}