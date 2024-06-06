﻿//HintName: G.Models.ReposCreateOrUpdateEnvironmentRequestReviewers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateOrUpdateEnvironmentRequestReviewers
    {
        /// <summary>
        /// The type of reviewer.
        /// <br/>Example: User
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ReposCreateOrUpdateEnvironmentRequestReviewersTypeJsonConverter))]
        public ReposCreateOrUpdateEnvironmentRequestReviewersType? Type { get; set; }

        /// <summary>
        /// The id of the user or team who can review the deployment
        /// <br/>Example: 4532992
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}