﻿//HintName: G.Models.DeleteCatalogFileResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteCatalogFileResponse
    {
        /// <summary>
        /// The file uid.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileUid")]
        public string? FileUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCatalogFileResponse" /> class.
        /// </summary>
        /// <param name="fileUid">
        /// The file uid.
        /// </param>
        public DeleteCatalogFileResponse(
            string? fileUid)
        {
            this.FileUid = fileUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCatalogFileResponse" /> class.
        /// </summary>
        public DeleteCatalogFileResponse()
        {
        }
    }
}