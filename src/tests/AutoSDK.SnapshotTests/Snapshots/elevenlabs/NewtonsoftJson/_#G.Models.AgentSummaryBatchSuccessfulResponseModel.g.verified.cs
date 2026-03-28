//HintName: G.Models.AgentSummaryBatchSuccessfulResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentSummaryBatchSuccessfulResponseModel
    {
        /// <summary>
        /// Default Value: success
        /// </summary>
        /// <default>"success"</default>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; } = "success";

        /// <summary>
        /// Example: {"access_info":{"creator_email":"john@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"},"agent_id":"J3Pbu5gP6NNKBscdCdwB","archived":false,"created_at_unix_secs":1716153600,"last_call_time_unix_secs":1716240000,"name":"My Agent","tags":["Customer Support","Technical Help","Eleven"]}
        /// </summary>
        /// <example>{"access_info":{"creator_email":"john@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"},"agent_id":"J3Pbu5gP6NNKBscdCdwB","archived":false,"created_at_unix_secs":1716153600,"last_call_time_unix_secs":1716240000,"name":"My Agent","tags":["Customer Support","Technical Help","Eleven"]}</example>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentSummaryResponseModel Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSummaryBatchSuccessfulResponseModel" /> class.
        /// </summary>
        /// <param name="data">
        /// Example: {"access_info":{"creator_email":"john@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"},"agent_id":"J3Pbu5gP6NNKBscdCdwB","archived":false,"created_at_unix_secs":1716153600,"last_call_time_unix_secs":1716240000,"name":"My Agent","tags":["Customer Support","Technical Help","Eleven"]}
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        public AgentSummaryBatchSuccessfulResponseModel(
            global::G.AgentSummaryResponseModel data,
            string status = "success")
        {
            this.Status = status;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSummaryBatchSuccessfulResponseModel" /> class.
        /// </summary>
        public AgentSummaryBatchSuccessfulResponseModel()
        {
        }
    }
}