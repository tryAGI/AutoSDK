//HintName: G.Models.BackoffPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackoffPlan
    {
        /// <summary>
        /// This is the type of backoff plan to use. Defaults to fixed.<br/>
        /// @default fixed<br/>
        /// Example: fixed
        /// </summary>
        /// <example>fixed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Type { get; set; }

        /// <summary>
        /// This is the maximum number of retries to attempt if the request fails. Defaults to 0 (no retries).<br/>
        /// @default 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxRetries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxRetries { get; set; }

        /// <summary>
        /// This is the base delay in seconds. For linear backoff, this is the delay between each retry. For exponential backoff, this is the initial delay.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseDelaySeconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BaseDelaySeconds { get; set; }

        /// <summary>
        /// This is the excluded status codes. If the response status code is in this list, the request will not be retried.<br/>
        /// By default, the request will be retried for any non-2xx status code.<br/>
        /// Example: [400, 401, 403, 404]
        /// </summary>
        /// <example>[400, 401, 403, 404]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludedStatusCodes")]
        public global::System.Collections.Generic.IList<object>? ExcludedStatusCodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackoffPlan" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of backoff plan to use. Defaults to fixed.<br/>
        /// @default fixed<br/>
        /// Example: fixed
        /// </param>
        /// <param name="maxRetries">
        /// This is the maximum number of retries to attempt if the request fails. Defaults to 0 (no retries).<br/>
        /// @default 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="baseDelaySeconds">
        /// This is the base delay in seconds. For linear backoff, this is the delay between each retry. For exponential backoff, this is the initial delay.<br/>
        /// Example: 1
        /// </param>
        /// <param name="excludedStatusCodes">
        /// This is the excluded status codes. If the response status code is in this list, the request will not be retried.<br/>
        /// By default, the request will be retried for any non-2xx status code.<br/>
        /// Example: [400, 401, 403, 404]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackoffPlan(
            object type,
            double maxRetries,
            double baseDelaySeconds,
            global::System.Collections.Generic.IList<object>? excludedStatusCodes)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.MaxRetries = maxRetries;
            this.BaseDelaySeconds = baseDelaySeconds;
            this.ExcludedStatusCodes = excludedStatusCodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackoffPlan" /> class.
        /// </summary>
        public BackoffPlan()
        {
        }
    }
}