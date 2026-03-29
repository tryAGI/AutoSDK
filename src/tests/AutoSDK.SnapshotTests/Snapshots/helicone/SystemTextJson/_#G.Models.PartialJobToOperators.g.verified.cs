//HintName: G.Models.PartialJobToOperators.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Make all properties in T optional
    /// </summary>
    public sealed partial class PartialJobToOperators
    {
        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::G.PartialTextOperators? Id { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::G.PartialTextOperators? Name { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::G.PartialTextOperators? Description { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::G.PartialTextOperators? Status { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::G.PartialTimestampOperators? CreatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::G.PartialTimestampOperators? UpdatedAt { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public global::G.PartialNumberOperators? TimeoutSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_properties")]
        public global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? CustomProperties { get; set; }

        /// <summary>
        /// Make all properties in T optional
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public global::G.PartialTextOperators? OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialJobToOperators" /> class.
        /// </summary>
        /// <param name="id">
        /// Make all properties in T optional
        /// </param>
        /// <param name="name">
        /// Make all properties in T optional
        /// </param>
        /// <param name="description">
        /// Make all properties in T optional
        /// </param>
        /// <param name="status">
        /// Make all properties in T optional
        /// </param>
        /// <param name="createdAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="updatedAt">
        /// Make all properties in T optional
        /// </param>
        /// <param name="timeoutSeconds">
        /// Make all properties in T optional
        /// </param>
        /// <param name="customProperties"></param>
        /// <param name="orgId">
        /// Make all properties in T optional
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialJobToOperators(
            global::G.PartialTextOperators? id,
            global::G.PartialTextOperators? name,
            global::G.PartialTextOperators? description,
            global::G.PartialTextOperators? status,
            global::G.PartialTimestampOperators? createdAt,
            global::G.PartialTimestampOperators? updatedAt,
            global::G.PartialNumberOperators? timeoutSeconds,
            global::System.Collections.Generic.Dictionary<string, global::G.PartialTextOperators>? customProperties,
            global::G.PartialTextOperators? orgId)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TimeoutSeconds = timeoutSeconds;
            this.CustomProperties = customProperties;
            this.OrgId = orgId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialJobToOperators" /> class.
        /// </summary>
        public PartialJobToOperators()
        {
        }
    }
}