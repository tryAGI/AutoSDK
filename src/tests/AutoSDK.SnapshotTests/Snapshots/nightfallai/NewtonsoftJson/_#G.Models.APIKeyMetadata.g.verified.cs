//HintName: G.Models.APIKeyMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class APIKeyMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyMetadata" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="kind"></param>
        /// <param name="description"></param>
        public APIKeyMetadata(
            string? status,
            string? kind,
            string? description)
        {
            this.Status = status;
            this.Kind = kind;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIKeyMetadata" /> class.
        /// </summary>
        public APIKeyMetadata()
        {
        }
    }
}