//HintName: G.Models.RetryConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for automatic retry of failed LLM requests with exponential backoff.
    /// </summary>
    public sealed partial class RetryConfiguration
    {
        /// <summary>
        /// Whether retry is enabled. Enabled by default to provide resilience against transient failures.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Maximum number of retry attempts after initial failure.<br/>
        /// Default Value: 3<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_retries")]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// Initial backoff time in milliseconds before first retry.<br/>
        /// Default Value: 1000<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_backoff_ms")]
        public int? InitialBackoffMs { get; set; }

        /// <summary>
        /// Maximum backoff time in milliseconds between retries.<br/>
        /// Default Value: 30000<br/>
        /// Example: 30000
        /// </summary>
        /// <example>30000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_backoff_ms")]
        public int? MaxBackoffMs { get; set; }

        /// <summary>
        /// Multiplication factor for exponential backoff between retries.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("backoff_factor")]
        public double? BackoffFactor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryConfiguration" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether retry is enabled. Enabled by default to provide resilience against transient failures.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="maxRetries">
        /// Maximum number of retry attempts after initial failure.<br/>
        /// Default Value: 3<br/>
        /// Example: 3
        /// </param>
        /// <param name="initialBackoffMs">
        /// Initial backoff time in milliseconds before first retry.<br/>
        /// Default Value: 1000<br/>
        /// Example: 1000
        /// </param>
        /// <param name="maxBackoffMs">
        /// Maximum backoff time in milliseconds between retries.<br/>
        /// Default Value: 30000<br/>
        /// Example: 30000
        /// </param>
        /// <param name="backoffFactor">
        /// Multiplication factor for exponential backoff between retries.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetryConfiguration(
            bool? enabled,
            int? maxRetries,
            int? initialBackoffMs,
            int? maxBackoffMs,
            double? backoffFactor)
        {
            this.Enabled = enabled;
            this.MaxRetries = maxRetries;
            this.InitialBackoffMs = initialBackoffMs;
            this.MaxBackoffMs = maxBackoffMs;
            this.BackoffFactor = backoffFactor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryConfiguration" /> class.
        /// </summary>
        public RetryConfiguration()
        {
        }
    }
}