//HintName: G.Models.ClearResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClearResponse
    {
        /// <summary>
        /// Default Value: ok
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Default Value: ok
        /// </param>
        public ClearResponse(
            string? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearResponse" /> class.
        /// </summary>
        public ClearResponse()
        {
        }
    }
}