//HintName: G.Models.OrganizationCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create organization schema.
    /// </summary>
    public sealed partial class OrganizationCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_personal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPersonal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreate" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="isPersonal"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrganizationCreate(
            string displayName,
            bool isPersonal)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.IsPersonal = isPersonal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreate" /> class.
        /// </summary>
        public OrganizationCreate()
        {
        }
    }
}