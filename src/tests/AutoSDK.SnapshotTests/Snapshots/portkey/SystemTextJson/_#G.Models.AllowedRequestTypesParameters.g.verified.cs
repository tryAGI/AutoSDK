//HintName: G.Models.AllowedRequestTypesParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for default.allowedRequestTypes check. Restrict which request types are allowed or blocked. You can use either or both; when both are specified, blocked types take precedence.
    /// </summary>
    public sealed partial class AllowedRequestTypesParameters
    {
        /// <summary>
        /// Request types to allow (allowlist). When set, only these request types are permitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedTypes")]
        public global::System.Collections.Generic.IList<global::G.AllowedRequestTypesParametersAllowedType>? AllowedTypes { get; set; }

        /// <summary>
        /// Request types to block (blocklist). When set, these request types are denied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedTypes")]
        public global::System.Collections.Generic.IList<global::G.AllowedRequestTypesParametersBlockedType>? BlockedTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedRequestTypesParameters" /> class.
        /// </summary>
        /// <param name="allowedTypes">
        /// Request types to allow (allowlist). When set, only these request types are permitted.
        /// </param>
        /// <param name="blockedTypes">
        /// Request types to block (blocklist). When set, these request types are denied.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AllowedRequestTypesParameters(
            global::System.Collections.Generic.IList<global::G.AllowedRequestTypesParametersAllowedType>? allowedTypes,
            global::System.Collections.Generic.IList<global::G.AllowedRequestTypesParametersBlockedType>? blockedTypes)
        {
            this.AllowedTypes = allowedTypes;
            this.BlockedTypes = blockedTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedRequestTypesParameters" /> class.
        /// </summary>
        public AllowedRequestTypesParameters()
        {
        }
    }
}