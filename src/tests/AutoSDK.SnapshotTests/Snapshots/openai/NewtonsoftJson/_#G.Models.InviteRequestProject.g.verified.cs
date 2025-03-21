//HintName: G.Models.InviteRequestProject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InviteRequestProject
    {
        /// <summary>
        /// Project's public ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Project membership role
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InviteRequestProjectRole Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteRequestProject" /> class.
        /// </summary>
        /// <param name="id">
        /// Project's public ID
        /// </param>
        /// <param name="role">
        /// Project membership role
        /// </param>
        public InviteRequestProject(
            string id,
            global::G.InviteRequestProjectRole role)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteRequestProject" /> class.
        /// </summary>
        public InviteRequestProject()
        {
        }
    }
}