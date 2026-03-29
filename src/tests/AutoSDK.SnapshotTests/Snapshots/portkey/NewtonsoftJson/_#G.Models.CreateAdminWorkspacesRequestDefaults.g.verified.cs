//HintName: G.Models.CreateAdminWorkspacesRequestDefaults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAdminWorkspacesRequestDefaults
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminWorkspacesRequestDefaults" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        public CreateAdminWorkspacesRequestDefaults(
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminWorkspacesRequestDefaults" /> class.
        /// </summary>
        public CreateAdminWorkspacesRequestDefaults()
        {
        }
    }
}