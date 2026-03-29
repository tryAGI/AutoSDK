//HintName: G.Models.GetAuthConfigsByNanoidResponseDeprecatedParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// DEPRECATED: This parameter will be removed in a future version.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GetAuthConfigsByNanoidResponseDeprecatedParams
    {
        /// <summary>
        /// Deprecated: Default connector ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_connector_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? DefaultConnectorId { get; set; }

        /// <summary>
        /// Deprecated: Member UUID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("member_uuid")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? MemberUuid { get; set; }

        /// <summary>
        /// Deprecated: Toolkit ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolkit_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ToolkitId { get; set; }

        /// <summary>
        /// Deprecated: Fields expected during connection initialization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expected_input_fields")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>>? ExpectedInputFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthConfigsByNanoidResponseDeprecatedParams" /> class.
        /// </summary>
        /// <param name="defaultConnectorId">
        /// Deprecated: Default connector ID
        /// </param>
        /// <param name="memberUuid">
        /// Deprecated: Member UUID
        /// </param>
        /// <param name="toolkitId">
        /// Deprecated: Toolkit ID
        /// </param>
        /// <param name="expectedInputFields">
        /// Deprecated: Fields expected during connection initialization
        /// </param>
        public GetAuthConfigsByNanoidResponseDeprecatedParams(
            string? defaultConnectorId,
            string? memberUuid,
            string? toolkitId,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>>? expectedInputFields)
        {
            this.DefaultConnectorId = defaultConnectorId;
            this.MemberUuid = memberUuid;
            this.ToolkitId = toolkitId;
            this.ExpectedInputFields = expectedInputFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthConfigsByNanoidResponseDeprecatedParams" /> class.
        /// </summary>
        public GetAuthConfigsByNanoidResponseDeprecatedParams()
        {
        }
    }
}