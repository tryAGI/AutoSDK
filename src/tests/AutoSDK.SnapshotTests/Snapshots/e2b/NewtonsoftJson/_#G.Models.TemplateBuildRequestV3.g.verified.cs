//HintName: G.Models.TemplateBuildRequestV3.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateBuildRequestV3
    {
        /// <summary>
        /// Name of the template. Can include a tag with colon separator (e.g. "my-template" or "my-template:v1"). If tag is included, it will be treated as if the tag was provided in the tags array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Tags to assign to the template build
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Alias of the template. Deprecated, use name instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alias")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Alias { get; set; }

        /// <summary>
        /// Identifier of the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teamID")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? TeamID { get; set; }

        /// <summary>
        /// CPU cores for the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpuCount")]
        public int? CpuCount { get; set; }

        /// <summary>
        /// Memory for the sandbox in MiB
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memoryMB")]
        public int? MemoryMB { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildRequestV3" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the template. Can include a tag with colon separator (e.g. "my-template" or "my-template:v1"). If tag is included, it will be treated as if the tag was provided in the tags array.
        /// </param>
        /// <param name="tags">
        /// Tags to assign to the template build
        /// </param>
        /// <param name="cpuCount">
        /// CPU cores for the sandbox
        /// </param>
        /// <param name="memoryMB">
        /// Memory for the sandbox in MiB
        /// </param>
        public TemplateBuildRequestV3(
            string? name,
            global::System.Collections.Generic.IList<string>? tags,
            int? cpuCount,
            int? memoryMB)
        {
            this.Name = name;
            this.Tags = tags;
            this.CpuCount = cpuCount;
            this.MemoryMB = memoryMB;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildRequestV3" /> class.
        /// </summary>
        public TemplateBuildRequestV3()
        {
        }
    }
}