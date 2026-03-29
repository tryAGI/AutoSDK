//HintName: G.Models.UpdateConfigRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.UpdateConfigRequestConfig? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConfigRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="config"></param>
        /// <param name="status"></param>
        public UpdateConfigRequest(
            string? name,
            global::G.UpdateConfigRequestConfig? config,
            string? status)
        {
            this.Name = name;
            this.Config = config;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConfigRequest" /> class.
        /// </summary>
        public UpdateConfigRequest()
        {
        }
    }
}