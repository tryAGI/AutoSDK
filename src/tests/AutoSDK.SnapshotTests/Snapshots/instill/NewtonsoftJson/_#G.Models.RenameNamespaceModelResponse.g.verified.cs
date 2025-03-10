﻿//HintName: G.Models.RenameNamespaceModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// RenameNamespaceModelResponse contains a renamed model.
    /// </summary>
    public sealed partial class RenameNamespaceModelResponse
    {
        /// <summary>
        /// The renamed model resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.Model? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameNamespaceModelResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// The renamed model resource.<br/>
        /// Included only in responses
        /// </param>
        public RenameNamespaceModelResponse(
            global::G.Model? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameNamespaceModelResponse" /> class.
        /// </summary>
        public RenameNamespaceModelResponse()
        {
        }
    }
}