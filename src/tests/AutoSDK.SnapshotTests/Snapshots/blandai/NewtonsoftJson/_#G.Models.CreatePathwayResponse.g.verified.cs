//HintName: G.Models.CreatePathwayResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePathwayResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreatePathwayResponseStatusJsonConverter))]
        public global::G.CreatePathwayResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pathway_id")]
        public string? PathwayId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePathwayResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="pathwayId"></param>
        public CreatePathwayResponse(
            global::G.CreatePathwayResponseStatus? status,
            string? pathwayId)
        {
            this.Status = status;
            this.PathwayId = pathwayId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePathwayResponse" /> class.
        /// </summary>
        public CreatePathwayResponse()
        {
        }
    }
}