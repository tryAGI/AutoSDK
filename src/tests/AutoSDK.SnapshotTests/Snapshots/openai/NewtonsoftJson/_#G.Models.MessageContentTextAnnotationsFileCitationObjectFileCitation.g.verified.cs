﻿//HintName: G.Models.MessageContentTextAnnotationsFileCitationObjectFileCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageContentTextAnnotationsFileCitationObjectFileCitation
    {
        /// <summary>
        /// The ID of the specific File the citation is from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextAnnotationsFileCitationObjectFileCitation" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the specific File the citation is from.
        /// </param>
        public MessageContentTextAnnotationsFileCitationObjectFileCitation(
            string fileId)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextAnnotationsFileCitationObjectFileCitation" /> class.
        /// </summary>
        public MessageContentTextAnnotationsFileCitationObjectFileCitation()
        {
        }
    }
}