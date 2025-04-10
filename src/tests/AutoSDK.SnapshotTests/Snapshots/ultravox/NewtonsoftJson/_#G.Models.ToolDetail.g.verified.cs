//HintName: G.Models.ToolDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolDetail
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("toolId")]
        public global::System.Guid ToolId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime Created { get; set; } = default!;

        /// <summary>
        /// The base definition of a tool that can be used during a call. Exactly one<br/>
        ///  implementation (http or client) should be set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("definition", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UltravoxV1BaseToolDefinition Definition { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("ownership")]
        public global::G.OwnershipEnum Ownership { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("statistics")]
        public global::G.ToolStatistics Statistics { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolDetail" /> class.
        /// </summary>
        /// <param name="toolId">
        /// Included only in responses
        /// </param>
        /// <param name="name"></param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="definition">
        /// The base definition of a tool that can be used during a call. Exactly one<br/>
        ///  implementation (http or client) should be set.
        /// </param>
        /// <param name="ownership">
        /// Included only in responses
        /// </param>
        /// <param name="statistics">
        /// Included only in responses
        /// </param>
        public ToolDetail(
            string name,
            global::G.UltravoxV1BaseToolDefinition definition,
            global::System.Guid toolId = default!,
            global::System.DateTime created = default!,
            global::G.OwnershipEnum ownership = default!,
            global::G.ToolStatistics statistics = default!)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
            this.ToolId = toolId;
            this.Created = created;
            this.Ownership = ownership;
            this.Statistics = statistics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolDetail" /> class.
        /// </summary>
        public ToolDetail()
        {
        }
    }
}