//HintName: G.Models.CreateOrganizationRequestOld.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationRequestOld
    {
        /// <summary>
        /// Name of the organization<br/>
        /// Example: My Organization
        /// </summary>
        /// <example>My Organization</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationRequestOld" /> class.
        /// </summary>
        /// <param name="orgName">
        /// Name of the organization<br/>
        /// Example: My Organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationRequestOld(
            string orgName)
        {
            this.OrgName = orgName ?? throw new global::System.ArgumentNullException(nameof(orgName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationRequestOld" /> class.
        /// </summary>
        public CreateOrganizationRequestOld()
        {
        }
    }
}