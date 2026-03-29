//HintName: G.Models.ProjectStatItemObjectPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ProjectStatItemObjectPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatItemObjectPublic" /> class.
        /// </summary>
        /// <param name="name"></param>
        public ProjectStatItemObjectPublic(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectStatItemObjectPublic" /> class.
        /// </summary>
        public ProjectStatItemObjectPublic()
        {
        }
    }
}