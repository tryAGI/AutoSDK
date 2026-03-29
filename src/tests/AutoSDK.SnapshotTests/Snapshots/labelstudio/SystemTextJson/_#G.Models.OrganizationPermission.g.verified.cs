//HintName: G.Models.OrganizationPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationPermission
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public global::System.Collections.Generic.IList<global::G.Default165Enum> Default { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public string? Group { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::G.Options165Enum> Options { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int Organization { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Permission { get; set; }

        /// <summary>
        /// Organization roles
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<global::G.Role9e7Enum>? Roles { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tooltip")]
        public string? Tooltip { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPermission" /> class.
        /// </summary>
        /// <param name="permission"></param>
        /// <param name="group">
        /// Included only in responses
        /// </param>
        /// <param name="label">
        /// Included only in responses
        /// </param>
        /// <param name="roles">
        /// Organization roles
        /// </param>
        /// <param name="tooltip">
        /// Included only in responses
        /// </param>
        /// <param name="default">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="options">
        /// Included only in responses
        /// </param>
        /// <param name="organization">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationPermission(
            string permission,
            string? group,
            string? label,
            global::System.Collections.Generic.IList<global::G.Role9e7Enum>? roles,
            string? tooltip,
            global::System.Collections.Generic.IList<global::G.Default165Enum> @default = default!,
            int id = default!,
            global::System.Collections.Generic.IList<global::G.Options165Enum> options = default!,
            int organization = default!)
        {
            this.Default = @default;
            this.Group = group;
            this.Id = id;
            this.Label = label;
            this.Options = options;
            this.Organization = organization;
            this.Permission = permission ?? throw new global::System.ArgumentNullException(nameof(permission));
            this.Roles = roles;
            this.Tooltip = tooltip;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationPermission" /> class.
        /// </summary>
        public OrganizationPermission()
        {
        }
    }
}