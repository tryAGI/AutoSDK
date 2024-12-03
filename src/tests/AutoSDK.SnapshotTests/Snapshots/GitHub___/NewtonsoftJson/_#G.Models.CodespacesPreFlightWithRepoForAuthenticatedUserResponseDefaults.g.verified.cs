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
        [global::Newtonsoft.Json.JsonProperty("location", Required = global::Newtonsoft.Json.Required.Always)]
        public string Location { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("devcontainer_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string? DevcontainerPath { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPreFlightWithRepoForAuthenticatedUserResponseDefaults" /> class.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="devcontainerPath"></param>
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