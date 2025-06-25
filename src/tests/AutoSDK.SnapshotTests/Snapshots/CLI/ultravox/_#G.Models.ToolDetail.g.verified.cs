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
        [global::System.Text.Json.Serialization.JsonPropertyName("toolId")]
        public global::System.Guid ToolId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime Created { get; set; } = default!;

        /// <summary>
        /// The base definition of a tool that can be used during a call. Exactly one<br/>
        ///  implementation (http or client) should be set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UltravoxV1BaseToolDefinition Definition { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownership")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OwnershipEnumJsonConverter))]
        public global::G.OwnershipEnum Ownership { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("statistics")]
        public global::G.ToolStatistics Statistics { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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