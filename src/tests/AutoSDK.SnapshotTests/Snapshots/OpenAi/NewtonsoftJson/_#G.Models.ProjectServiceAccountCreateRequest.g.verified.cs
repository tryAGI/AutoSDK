//HintName: G.Models.ProjectServiceAccountCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectServiceAccountCreateRequest
    {
        /// <summary>
        /// The name of the service account being created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectServiceAccountCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the service account being created.
        /// </param>
        public ProjectServiceAccountCreateRequest(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectServiceAccountCreateRequest" /> class.
        /// </summary>
        public ProjectServiceAccountCreateRequest()
        {
        }
    }
}