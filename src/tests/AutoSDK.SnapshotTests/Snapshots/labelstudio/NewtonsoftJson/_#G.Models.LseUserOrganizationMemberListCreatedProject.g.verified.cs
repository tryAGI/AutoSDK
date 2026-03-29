//HintName: G.Models.LseUserOrganizationMemberListCreatedProject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LseUserOrganizationMemberListCreatedProject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LseUserOrganizationMemberListCreatedProject" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        public LseUserOrganizationMemberListCreatedProject(
            int id,
            string title)
        {
            this.Id = id;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LseUserOrganizationMemberListCreatedProject" /> class.
        /// </summary>
        public LseUserOrganizationMemberListCreatedProject()
        {
        }
    }
}