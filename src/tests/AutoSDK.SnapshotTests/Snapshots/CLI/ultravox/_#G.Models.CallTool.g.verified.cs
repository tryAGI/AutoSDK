﻿//HintName: G.Models.CallTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallTool
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("callToolId")]
        public global::System.Guid CallToolId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolId")]
        public global::System.Guid? ToolId { get; set; }

        /// <summary>
        /// The possibly overridden name of the tool.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A tool as used for a particular call (omitting auth details).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UltravoxV1CallTool Definition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallTool" /> class.
        /// </summary>
        /// <param name="callToolId">
        /// Included only in responses
        /// </param>
        /// <param name="toolId">
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// The possibly overridden name of the tool.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="definition">
        /// A tool as used for a particular call (omitting auth details).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallTool(
            global::G.UltravoxV1CallTool definition,
            global::System.Guid? toolId,
            global::System.Guid callToolId = default!,
            string name = default!)
        {
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
            this.CallToolId = callToolId;
            this.ToolId = toolId;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallTool" /> class.
        /// </summary>
        public CallTool()
        {
        }
    }
}