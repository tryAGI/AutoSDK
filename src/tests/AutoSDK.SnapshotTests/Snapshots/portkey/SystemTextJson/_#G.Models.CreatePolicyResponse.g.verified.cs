//HintName: G.Models.CreatePolicyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePolicyResponse
    {
        /// <summary>
        /// Created policy UUID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Resource type<br/>
        /// Example: policy_usage_limits
        /// </summary>
        /// <example>policy_usage_limits</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePolicyResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Created policy UUID
        /// </param>
        /// <param name="object">
        /// Resource type<br/>
        /// Example: policy_usage_limits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePolicyResponse(
            global::System.Guid? id,
            string? @object)
        {
            this.Id = id;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePolicyResponse" /> class.
        /// </summary>
        public CreatePolicyResponse()
        {
        }
    }
}