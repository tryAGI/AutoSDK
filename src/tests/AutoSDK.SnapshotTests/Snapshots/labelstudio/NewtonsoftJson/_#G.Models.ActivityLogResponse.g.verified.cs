//HintName: G.Models.ActivityLogResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for ActivityLogAPI response.
    /// </summary>
    public sealed partial class ActivityLogResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ActivityLog> Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recordsFiltered", Required = global::Newtonsoft.Json.Required.Always)]
        public int RecordsFiltered { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recordsTotal", Required = global::Newtonsoft.Json.Required.Always)]
        public int RecordsTotal { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityLogResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="recordsFiltered"></param>
        /// <param name="recordsTotal"></param>
        public ActivityLogResponse(
            global::System.Collections.Generic.IList<global::G.ActivityLog> data,
            int recordsFiltered,
            int recordsTotal)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.RecordsFiltered = recordsFiltered;
            this.RecordsTotal = recordsTotal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityLogResponse" /> class.
        /// </summary>
        public ActivityLogResponse()
        {
        }
    }
}