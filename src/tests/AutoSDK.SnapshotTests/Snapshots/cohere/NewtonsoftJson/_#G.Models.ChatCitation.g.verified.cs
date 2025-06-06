﻿//HintName: G.Models.ChatCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A section of the generated reply which cites external knowledge.
    /// </summary>
    public sealed partial class ChatCitation
    {
        /// <summary>
        /// The index of text that the citation starts at, counting from zero. For example, a generation of `Hello, world!` with a citation on `world` would have a start value of `7`. This is because the citation starts at `w`, which is the seventh character.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public int Start { get; set; } = default!;

        /// <summary>
        /// The index of text that the citation ends after, counting from zero. For example, a generation of `Hello, world!` with a citation on `world` would have an end value of `11`. This is because the citation ends after `d`, which is the eleventh character.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public int End { get; set; } = default!;

        /// <summary>
        /// The text of the citation. For example, a generation of `Hello, world!` with a citation of `world` would have a text value of `world`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Identifiers of documents cited by this section of the generated reply.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> DocumentIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCitation" /> class.
        /// </summary>
        /// <param name="start">
        /// The index of text that the citation starts at, counting from zero. For example, a generation of `Hello, world!` with a citation on `world` would have a start value of `7`. This is because the citation starts at `w`, which is the seventh character.
        /// </param>
        /// <param name="end">
        /// The index of text that the citation ends after, counting from zero. For example, a generation of `Hello, world!` with a citation on `world` would have an end value of `11`. This is because the citation ends after `d`, which is the eleventh character.
        /// </param>
        /// <param name="text">
        /// The text of the citation. For example, a generation of `Hello, world!` with a citation of `world` would have a text value of `world`.
        /// </param>
        /// <param name="documentIds">
        /// Identifiers of documents cited by this section of the generated reply.
        /// </param>
        public ChatCitation(
            int start,
            int end,
            string text,
            global::System.Collections.Generic.IList<string> documentIds)
        {
            this.Start = start;
            this.End = end;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.DocumentIds = documentIds ?? throw new global::System.ArgumentNullException(nameof(documentIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCitation" /> class.
        /// </summary>
        public ChatCitation()
        {
        }
    }
}