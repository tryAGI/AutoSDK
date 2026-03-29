//HintName: G.Models.ApiProjectsMembersBulkCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsMembersBulkCreateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignments")]
        public int? Assignments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsMembersBulkCreateResponse" /> class.
        /// </summary>
        /// <param name="assignments"></param>
        public ApiProjectsMembersBulkCreateResponse(
            int? assignments)
        {
            this.Assignments = assignments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsMembersBulkCreateResponse" /> class.
        /// </summary>
        public ApiProjectsMembersBulkCreateResponse()
        {
        }
    }
}