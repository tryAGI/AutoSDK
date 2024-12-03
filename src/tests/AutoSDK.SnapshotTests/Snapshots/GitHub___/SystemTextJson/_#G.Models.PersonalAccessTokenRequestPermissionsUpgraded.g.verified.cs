//HintName: G.Models.PersonalAccessTokenRequestPermissionsUpgraded.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Requested permissions that elevate access for a previously approved request for access, categorized by type of permission.
    /// </summary>
    public sealed partial class PersonalAccessTokenRequestPermissionsUpgraded
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::System.Collections.Generic.Dictionary<string, string>? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::System.Collections.Generic.Dictionary<string, string>? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other")]
        public global::System.Collections.Generic.Dictionary<string, string>? Other { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalAccessTokenRequestPermissionsUpgraded" /> class.
        /// </summary>
        /// <param name="organization"></param>
        /// <param name="repository"></param>
        /// <param name="other"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PersonalAccessTokenRequestPermissionsUpgraded(
            global::System.Collections.Generic.Dictionary<string, string>? organization,
            global::System.Collections.Generic.Dictionary<string, string>? repository,
            global::System.Collections.Generic.Dictionary<string, string>? other)
        {
            this.Organization = organization;
            this.Repository = repository;
            this.Other = other;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalAccessTokenRequestPermissionsUpgraded" /> class.
        /// </summary>
        public PersonalAccessTokenRequestPermissionsUpgraded()
        {
        }
    }
}