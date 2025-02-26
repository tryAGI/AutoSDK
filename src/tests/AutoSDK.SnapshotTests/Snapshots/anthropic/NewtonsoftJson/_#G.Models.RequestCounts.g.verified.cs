//HintName: G.Models.RequestCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestCounts
    {
        /// <summary>
        /// Number of requests in the Message Batch that are processing.<br/>
        /// Default Value: 0<br/>
        /// Example: 100
        /// </summary>
        /// <default>0</default>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("processing", Required = global::Newtonsoft.Json.Required.Always)]
        public int Processing { get; set; } = default!;

        /// <summary>
        /// Number of requests in the Message Batch that have completed successfully.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0<br/>
        /// Example: 50
        /// </summary>
        /// <default>0</default>
        /// <example>50</example>
        [global::Newtonsoft.Json.JsonProperty("succeeded", Required = global::Newtonsoft.Json.Required.Always)]
        public int Succeeded { get; set; } = default!;

        /// <summary>
        /// Number of requests in the Message Batch that encountered an error.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0<br/>
        /// Example: 30
        /// </summary>
        /// <default>0</default>
        /// <example>30</example>
        [global::Newtonsoft.Json.JsonProperty("errored", Required = global::Newtonsoft.Json.Required.Always)]
        public int Errored { get; set; } = default!;

        /// <summary>
        /// Number of requests in the Message Batch that have been canceled.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </summary>
        /// <default>0</default>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("canceled", Required = global::Newtonsoft.Json.Required.Always)]
        public int Canceled { get; set; } = default!;

        /// <summary>
        /// Number of requests in the Message Batch that have expired.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </summary>
        /// <default>0</default>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("expired", Required = global::Newtonsoft.Json.Required.Always)]
        public int Expired { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCounts" /> class.
        /// </summary>
        /// <param name="processing">
        /// Number of requests in the Message Batch that are processing.<br/>
        /// Default Value: 0<br/>
        /// Example: 100
        /// </param>
        /// <param name="succeeded">
        /// Number of requests in the Message Batch that have completed successfully.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0<br/>
        /// Example: 50
        /// </param>
        /// <param name="errored">
        /// Number of requests in the Message Batch that encountered an error.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0<br/>
        /// Example: 30
        /// </param>
        /// <param name="canceled">
        /// Number of requests in the Message Batch that have been canceled.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </param>
        /// <param name="expired">
        /// Number of requests in the Message Batch that have expired.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </param>
        public RequestCounts(
            int processing,
            int succeeded,
            int errored,
            int canceled,
            int expired)
        {
            this.Processing = processing;
            this.Succeeded = succeeded;
            this.Errored = errored;
            this.Canceled = canceled;
            this.Expired = expired;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCounts" /> class.
        /// </summary>
        public RequestCounts()
        {
        }
    }
}