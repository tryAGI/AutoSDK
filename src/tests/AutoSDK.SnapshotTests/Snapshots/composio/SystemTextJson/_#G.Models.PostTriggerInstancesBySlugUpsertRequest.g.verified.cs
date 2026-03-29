//HintName: G.Models.PostTriggerInstancesBySlugUpsertRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostTriggerInstancesBySlugUpsertRequest
    {
        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version. Please use connected_account_id instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectedAuthId")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ConnectedAuthId { get; set; }

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version. Please use trigger_config instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerConfig")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, object?>? TriggerConfig { get; set; }

        /// <summary>
        /// Connected account nanoid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_account_id")]
        public string? ConnectedAccountId { get; set; }

        /// <summary>
        /// Trigger configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_config")]
        public global::System.Collections.Generic.Dictionary<string, object?>? TriggerConfig2 { get; set; }

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version. Please use toolkit_versions instead.<br/>
        /// Example: latest
        /// </summary>
        /// <example>latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Version { get; set; }

        /// <summary>
        /// Toolkit version specification. Supports "latest" string or a record mapping toolkit slugs to specific versions.<br/>
        /// Example: latest
        /// </summary>
        /// <example>latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit_versions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, string>, object>))]
        public global::G.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>, object>? ToolkitVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTriggerInstancesBySlugUpsertRequest" /> class.
        /// </summary>
        /// <param name="connectedAccountId">
        /// Connected account nanoid
        /// </param>
        /// <param name="triggerConfig2">
        /// Trigger configuration
        /// </param>
        /// <param name="toolkitVersions">
        /// Toolkit version specification. Supports "latest" string or a record mapping toolkit slugs to specific versions.<br/>
        /// Example: latest
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostTriggerInstancesBySlugUpsertRequest(
            string? connectedAccountId,
            global::System.Collections.Generic.Dictionary<string, object?>? triggerConfig2,
            global::G.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>, object>? toolkitVersions)
        {
            this.ConnectedAccountId = connectedAccountId;
            this.TriggerConfig2 = triggerConfig2;
            this.ToolkitVersions = toolkitVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTriggerInstancesBySlugUpsertRequest" /> class.
        /// </summary>
        public PostTriggerInstancesBySlugUpsertRequest()
        {
        }
    }
}