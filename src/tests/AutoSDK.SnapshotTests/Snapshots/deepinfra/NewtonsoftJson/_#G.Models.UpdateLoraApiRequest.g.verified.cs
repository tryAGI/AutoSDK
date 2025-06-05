//HintName: G.Models.UpdateLoraApiRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateLoraApiRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private")]
        public bool? Private { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateLoraApiRequest" /> class.
        /// </summary>
        /// <param name="private"></param>
        /// <param name="description"></param>
        public UpdateLoraApiRequest(
            bool? @private,
            string? description)
        {
            this.Private = @private;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLoraApiRequest" /> class.
        /// </summary>
        public UpdateLoraApiRequest()
        {
        }
    }
}