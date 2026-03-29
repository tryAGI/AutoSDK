//HintName: G.Models.GetConnectedAccountsByNanoidResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetConnectedAccountsByNanoidResponseToolkit Toolkit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetConnectedAccountsByNanoidResponseAuthConfig AuthConfig { get; set; }

        /// <summary>
        /// The id of the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is deprecated, we will not be providing userId from this api anymore, you will only be able to read via userId not get it back
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The status of the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetConnectedAccountsByNanoidResponseStatus Status { get; set; }

        /// <summary>
        /// The created at of the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The updated at of the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// The state of the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.GetConnectedAccountsByNanoidResponseStateVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant4, global::G.GetConnectedAccountsByNanoidResponseStateVariant5, global::G.GetConnectedAccountsByNanoidResponseStateVariant6, global::G.GetConnectedAccountsByNanoidResponseStateVariant7, global::G.GetConnectedAccountsByNanoidResponseStateVariant8, global::G.GetConnectedAccountsByNanoidResponseStateVariant9, global::G.GetConnectedAccountsByNanoidResponseStateVariant10, global::G.GetConnectedAccountsByNanoidResponseStateVariant11, global::G.GetConnectedAccountsByNanoidResponseStateVariant12, global::G.GetConnectedAccountsByNanoidResponseStateVariant13, global::G.GetConnectedAccountsByNanoidResponseStateVariant14>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant4, global::G.GetConnectedAccountsByNanoidResponseStateVariant5, global::G.GetConnectedAccountsByNanoidResponseStateVariant6, global::G.GetConnectedAccountsByNanoidResponseStateVariant7, global::G.GetConnectedAccountsByNanoidResponseStateVariant8, global::G.GetConnectedAccountsByNanoidResponseStateVariant9, global::G.GetConnectedAccountsByNanoidResponseStateVariant10, global::G.GetConnectedAccountsByNanoidResponseStateVariant11, global::G.GetConnectedAccountsByNanoidResponseStateVariant12, global::G.GetConnectedAccountsByNanoidResponseStateVariant13, global::G.GetConnectedAccountsByNanoidResponseStateVariant14> State { get; set; }

        /// <summary>
        /// This is deprecated, use `state` instead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Data { get; set; }

        /// <summary>
        /// The reason the connection status changed. Possible reasons: Connection initiation did not complete within 10 minutes, Permanent auth error during token refresh, Max auth failures reached, OAuth callback failed during token exchange, Connection status updated by user, Auth config is disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_reason")]
        public string? StatusReason { get; set; }

        /// <summary>
        /// Whether the connection is disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDisabled { get; set; }

        /// <summary>
        /// The endpoint to make test request for verification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_request_endpoint")]
        public string? TestRequestEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.GetConnectedAccountsByNanoidResponseDeprecated? Deprecated { get; set; }

        /// <summary>
        /// The initialization data of the connection, including configuration parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponse" /> class.
        /// </summary>
        /// <param name="toolkit"></param>
        /// <param name="authConfig"></param>
        /// <param name="id">
        /// The id of the connection
        /// </param>
        /// <param name="userId">
        /// This is deprecated, we will not be providing userId from this api anymore, you will only be able to read via userId not get it back
        /// </param>
        /// <param name="status">
        /// The status of the connection
        /// </param>
        /// <param name="createdAt">
        /// The created at of the connection
        /// </param>
        /// <param name="updatedAt">
        /// The updated at of the connection
        /// </param>
        /// <param name="state">
        /// The state of the connection
        /// </param>
        /// <param name="data">
        /// This is deprecated, use `state` instead
        /// </param>
        /// <param name="isDisabled">
        /// Whether the connection is disabled
        /// </param>
        /// <param name="params">
        /// The initialization data of the connection, including configuration parameters
        /// </param>
        /// <param name="statusReason">
        /// The reason the connection status changed. Possible reasons: Connection initiation did not complete within 10 minutes, Permanent auth error during token refresh, Max auth failures reached, OAuth callback failed during token exchange, Connection status updated by user, Auth config is disabled
        /// </param>
        /// <param name="testRequestEndpoint">
        /// The endpoint to make test request for verification
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsByNanoidResponse(
            global::G.GetConnectedAccountsByNanoidResponseToolkit toolkit,
            global::G.GetConnectedAccountsByNanoidResponseAuthConfig authConfig,
            string id,
            string userId,
            global::G.GetConnectedAccountsByNanoidResponseStatus status,
            string createdAt,
            string updatedAt,
            global::G.OneOf<global::G.GetConnectedAccountsByNanoidResponseStateVariant1, global::G.GetConnectedAccountsByNanoidResponseStateVariant2, global::G.GetConnectedAccountsByNanoidResponseStateVariant3, global::G.GetConnectedAccountsByNanoidResponseStateVariant4, global::G.GetConnectedAccountsByNanoidResponseStateVariant5, global::G.GetConnectedAccountsByNanoidResponseStateVariant6, global::G.GetConnectedAccountsByNanoidResponseStateVariant7, global::G.GetConnectedAccountsByNanoidResponseStateVariant8, global::G.GetConnectedAccountsByNanoidResponseStateVariant9, global::G.GetConnectedAccountsByNanoidResponseStateVariant10, global::G.GetConnectedAccountsByNanoidResponseStateVariant11, global::G.GetConnectedAccountsByNanoidResponseStateVariant12, global::G.GetConnectedAccountsByNanoidResponseStateVariant13, global::G.GetConnectedAccountsByNanoidResponseStateVariant14> state,
            global::System.Collections.Generic.Dictionary<string, object?> data,
            bool isDisabled,
            global::System.Collections.Generic.Dictionary<string, object?> @params,
            string? statusReason,
            string? testRequestEndpoint)
        {
            this.Toolkit = toolkit ?? throw new global::System.ArgumentNullException(nameof(toolkit));
            this.AuthConfig = authConfig ?? throw new global::System.ArgumentNullException(nameof(authConfig));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Status = status;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.State = state;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.StatusReason = statusReason;
            this.IsDisabled = isDisabled;
            this.TestRequestEndpoint = testRequestEndpoint;
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponse" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponse()
        {
        }
    }
}