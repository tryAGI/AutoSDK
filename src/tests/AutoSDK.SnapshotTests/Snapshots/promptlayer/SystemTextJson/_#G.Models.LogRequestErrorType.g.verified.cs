//HintName: G.Models.LogRequestErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Categorized error type.<br/>
    /// | Value | Description | Allowed Statuses |<br/>
    /// |-------|-------------|------------------|<br/>
    /// | `PROVIDER_RATE_LIMIT` | Rate limit hit on provider API | WARNING, ERROR |<br/>
    /// | `PROVIDER_QUOTA_LIMIT` | Account quota or spending limit exceeded | WARNING, ERROR |<br/>
    /// | `VARIABLE_MISSING_OR_EMPTY` | Required template variable was missing or empty | WARNING |<br/>
    /// | `PROVIDER_TIMEOUT` | Request timed out | ERROR |<br/>
    /// | `PROVIDER_AUTH_ERROR` | Authentication failed with provider | ERROR |<br/>
    /// | `PROVIDER_ERROR` | General provider-side error | ERROR |<br/>
    /// | `TEMPLATE_RENDER_ERROR` | Failed to render prompt template | ERROR |<br/>
    /// | `UNKNOWN_ERROR` | Uncategorized error | WARNING, ERROR |<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class LogRequestErrorType
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}