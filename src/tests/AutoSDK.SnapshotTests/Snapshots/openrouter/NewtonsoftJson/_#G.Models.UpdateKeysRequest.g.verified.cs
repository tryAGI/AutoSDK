//HintName: G.Models.UpdateKeysRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateKeysRequest
    {
        /// <summary>
        /// New name for the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether to disable the API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// New spending limit for the API key in USD
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// New limit reset type for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit_reset")]
        public global::G.OneOf<global::G.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset?, object>? LimitReset { get; set; }

        /// <summary>
        /// Whether to include BYOK usage in the limit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_byok_in_limit")]
        public bool? IncludeByokInLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKeysRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the API key
        /// </param>
        /// <param name="disabled">
        /// Whether to disable the API key
        /// </param>
        /// <param name="limit">
        /// New spending limit for the API key in USD
        /// </param>
        /// <param name="limitReset">
        /// New limit reset type for the API key (daily, weekly, monthly, or null for no reset). Resets happen automatically at midnight UTC, and weeks are Monday through Sunday.
        /// </param>
        /// <param name="includeByokInLimit">
        /// Whether to include BYOK usage in the limit
        /// </param>
        public UpdateKeysRequest(
            string? name,
            bool? disabled,
            double? limit,
            global::G.OneOf<global::G.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset?, object>? limitReset,
            bool? includeByokInLimit)
        {
            this.Name = name;
            this.Disabled = disabled;
            this.Limit = limit;
            this.LimitReset = limitReset;
            this.IncludeByokInLimit = includeByokInLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateKeysRequest" /> class.
        /// </summary>
        public UpdateKeysRequest()
        {
        }
    }
}