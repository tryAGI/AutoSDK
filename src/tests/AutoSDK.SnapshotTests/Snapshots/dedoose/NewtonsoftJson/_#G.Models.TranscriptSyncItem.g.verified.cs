﻿//HintName: G.Models.TranscriptSyncItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptSyncItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectIdKey")]
        public string? ProjectIdKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceId")]
        public global::System.Guid? ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriptId")]
        public global::System.Guid? TranscriptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourcePosition")]
        public int? ResourcePosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriptPosition")]
        public int? TranscriptPosition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptSyncItem" /> class.
        /// </summary>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="transcriptId"></param>
        /// <param name="resourcePosition"></param>
        /// <param name="transcriptPosition"></param>
        public TranscriptSyncItem(
            string? projectIdKey,
            global::System.Guid? id,
            global::System.Guid? projectId,
            global::System.Guid? resourceId,
            global::System.Guid? transcriptId,
            int? resourcePosition,
            int? transcriptPosition)
        {
            this.ProjectIdKey = projectIdKey;
            this.Id = id;
            this.ProjectId = projectId;
            this.ResourceId = resourceId;
            this.TranscriptId = transcriptId;
            this.ResourcePosition = resourcePosition;
            this.TranscriptPosition = transcriptPosition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptSyncItem" /> class.
        /// </summary>
        public TranscriptSyncItem()
        {
        }
    }
}