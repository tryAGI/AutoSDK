//HintName: G.Models.GetAuthSessionInfoResponseProjectOrg.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Organization details
    /// </summary>
    public sealed partial class GetAuthSessionInfoResponseProjectOrg
    {
        /// <summary>
        /// Short, URL-friendly unique identifier for the organization<br/>
        /// Example: org_abc123xyz456
        /// </summary>
        /// <example>org_abc123xyz456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// User-defined name for the organization<br/>
        /// Example: Acme Corp
        /// </summary>
        /// <example>Acme Corp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Current subscription plan level<br/>
        /// Example: BUSINESS
        /// </summary>
        /// <example>BUSINESS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthSessionInfoResponseProjectOrg" /> class.
        /// </summary>
        /// <param name="id">
        /// Short, URL-friendly unique identifier for the organization<br/>
        /// Example: org_abc123xyz456
        /// </param>
        /// <param name="name">
        /// User-defined name for the organization<br/>
        /// Example: Acme Corp
        /// </param>
        /// <param name="plan">
        /// Current subscription plan level<br/>
        /// Example: BUSINESS
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAuthSessionInfoResponseProjectOrg(
            string id,
            string name,
            string plan)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthSessionInfoResponseProjectOrg" /> class.
        /// </summary>
        public GetAuthSessionInfoResponseProjectOrg()
        {
        }
    }
}