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
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Processing { get; set; } = 0;

        /// <summary>
        /// Number of requests in the Message Batch that have completed successfully.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0<br/>
        /// Example: 50
        /// </summary>
        /// <default>0</default>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeeded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Succeeded { get; set; } = 0;

        /// <summary>
        /// Number of requests in the Message Batch that encountered an error.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0<br/>
        /// Example: 30
        /// </summary>
        /// <default>0</default>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("errored")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Errored { get; set; } = 0;

        /// <summary>
        /// Number of requests in the Message Batch that have been canceled.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </summary>
        /// <default>0</default>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Canceled { get; set; } = 0;

        /// <summary>
        /// Number of requests in the Message Batch that have expired.<br/>
        /// This is zero until processing of the entire Message Batch has ended.<br/>
        /// Default Value: 0<br/>
        /// Example: 10
        /// </summary>
        /// <default>0</default>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Expired { get; set; } = 0;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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