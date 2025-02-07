//HintName: G.Models.CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devcontainer_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? DevcontainerPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults" /> class.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="devcontainerPath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults(
            string location,
            string? devcontainerPath)
        {
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
            this.DevcontainerPath = devcontainerPath ?? throw new global::System.ArgumentNullException(nameof(devcontainerPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults" /> class.
        /// </summary>
        public CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults()
        {
        }
    }
}