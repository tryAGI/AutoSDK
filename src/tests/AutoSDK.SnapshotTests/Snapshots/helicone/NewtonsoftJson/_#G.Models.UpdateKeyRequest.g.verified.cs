//HintName: G.Models.UpdateKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateKeyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKeyRequest" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="name"></param>
        /// <param name="key"></param>
        public UpdateKeyRequest(
            bool? active,
            string? name,
            string? key)
        {
            this.Active = active;
            this.Name = name;
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKeyRequest" /> class.
        /// </summary>
        public UpdateKeyRequest()
        {
        }
    }
}