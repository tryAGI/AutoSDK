//HintName: G.Models.GetAuthConfigsResponseItemDeprecatedParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// DEPRECATED: This parameter will be removed in a future version.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GetAuthConfigsResponseItemDeprecatedParams
    {
        /// <summary>
        /// Deprecated: Default connector ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_connector_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? DefaultConnectorId { get; set; }

        /// <summary>
        /// Deprecated: Member UUID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_uuid")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? MemberUuid { get; set; }

        /// <summary>
        /// Deprecated: Toolkit ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ToolkitId { get; set; }

        /// <summary>
        /// Deprecated: Fields expected during connection initialization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_input_fields")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, object?>>? ExpectedInputFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthConfigsResponseItemDeprecatedParams" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAuthConfigsResponseItemDeprecatedParams(
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
        /// Initializes a new instance of the <see cref="GetAuthConfigsResponseItemDeprecatedParams" /> class.
        /// </summary>
        public GetAuthConfigsResponseItemDeprecatedParams()
        {
        }
    }
}