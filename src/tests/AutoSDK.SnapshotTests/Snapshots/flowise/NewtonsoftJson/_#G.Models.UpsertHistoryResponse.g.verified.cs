//HintName: G.Models.UpsertHistoryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpsertHistoryResponse
    {
        /// <summary>
        /// Unique identifier for the upsert history record<br/>
        /// Example: cfd531e0-82fc-11e9-bc42-526af7764f64
        /// </summary>
        /// <example>cfd531e0-82fc-11e9-bc42-526af7764f64</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// ID of the chatflow associated with the upsert history<br/>
        /// Example: 7c4e8b7a-7b9a-4b4d-9f3e-2d28f1ebea02
        /// </summary>
        /// <example>7c4e8b7a-7b9a-4b4d-9f3e-2d28f1ebea02</example>
        [global::Newtonsoft.Json.JsonProperty("chatflowid")]
        public string? Chatflowid { get; set; }

        /// <summary>
        /// Result of the upsert operation, stored as a JSON string<br/>
        /// Example: {"status":"success","data":{"key":"value"}}
        /// </summary>
        /// <example>{"status":"success","data":{"key":"value"}}</example>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public string? Result { get; set; }

        /// <summary>
        /// Flow data associated with the upsert operation, stored as a JSON string<br/>
        /// Example: {"nodes":[],"edges":[]}
        /// </summary>
        /// <example>{"nodes":[],"edges":[]}</example>
        [global::Newtonsoft.Json.JsonProperty("flowData")]
        public string? FlowData { get; set; }

        /// <summary>
        /// Date and time when the upsert operation was performed<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </summary>
        /// <example>2024-08-24T14:15:22Z</example>
        [global::Newtonsoft.Json.JsonProperty("date")]
        public global::System.DateTime? Date { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertHistoryResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the upsert history record<br/>
        /// Example: cfd531e0-82fc-11e9-bc42-526af7764f64
        /// </param>
        /// <param name="chatflowid">
        /// ID of the chatflow associated with the upsert history<br/>
        /// Example: 7c4e8b7a-7b9a-4b4d-9f3e-2d28f1ebea02
        /// </param>
        /// <param name="result">
        /// Result of the upsert operation, stored as a JSON string<br/>
        /// Example: {"status":"success","data":{"key":"value"}}
        /// </param>
        /// <param name="flowData">
        /// Flow data associated with the upsert operation, stored as a JSON string<br/>
        /// Example: {"nodes":[],"edges":[]}
        /// </param>
        /// <param name="date">
        /// Date and time when the upsert operation was performed<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        public UpsertHistoryResponse(
            global::System.Guid? id,
            string? chatflowid,
            string? result,
            string? flowData,
            global::System.DateTime? date)
        {
            this.Id = id;
            this.Chatflowid = chatflowid;
            this.Result = result;
            this.FlowData = flowData;
            this.Date = date;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertHistoryResponse" /> class.
        /// </summary>
        public UpsertHistoryResponse()
        {
        }
    }
}