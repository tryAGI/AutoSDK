﻿//HintName: G.Models.ToolAnnotations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional properties describing a Tool to clients.<br/>
    /// NOTE: all properties in ToolAnnotations are **hints**.<br/>
    /// They are not guaranteed to provide a faithful description of<br/>
    /// tool behavior (including descriptive properties like `title`).<br/>
    /// Clients should never make tool use decisions based on ToolAnnotations<br/>
    /// received from untrusted servers.
    /// </summary>
    public sealed partial class ToolAnnotations
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readOnlyHint")]
        public bool? ReadOnlyHint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destructiveHint")]
        public bool? DestructiveHint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idempotentHint")]
        public bool? IdempotentHint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openWorldHint")]
        public bool? OpenWorldHint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolAnnotations" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="readOnlyHint"></param>
        /// <param name="destructiveHint"></param>
        /// <param name="idempotentHint"></param>
        /// <param name="openWorldHint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolAnnotations(
            string? title,
            bool? readOnlyHint,
            bool? destructiveHint,
            bool? idempotentHint,
            bool? openWorldHint)
        {
            this.Title = title;
            this.ReadOnlyHint = readOnlyHint;
            this.DestructiveHint = destructiveHint;
            this.IdempotentHint = idempotentHint;
            this.OpenWorldHint = openWorldHint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolAnnotations" /> class.
        /// </summary>
        public ToolAnnotations()
        {
        }
    }
}