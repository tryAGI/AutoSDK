//HintName: G.Models.InvocationsGetLogsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InvocationsGetLogsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.InvocationLog> Logs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public double Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvocationsGetLogsResponse" /> class.
        /// </summary>
        /// <param name="logs"></param>
        /// <param name="total"></param>
        public InvocationsGetLogsResponse(
            global::System.Collections.Generic.IList<global::G.InvocationLog> logs,
            double total)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvocationsGetLogsResponse" /> class.
        /// </summary>
        public InvocationsGetLogsResponse()
        {
        }
    }
}