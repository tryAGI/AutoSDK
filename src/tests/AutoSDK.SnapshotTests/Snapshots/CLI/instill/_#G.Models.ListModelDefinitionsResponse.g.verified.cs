﻿//HintName: G.Models.ListModelDefinitionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListModelDefinitionsResponse contains a list of model definitions.
    /// </summary>
    public sealed partial class ListModelDefinitionsResponse
    {
        /// <summary>
        /// A list of model definition resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelDefinitions")]
        public global::System.Collections.Generic.IList<global::G.ModelDefinition>? ModelDefinitions { get; set; }

        /// <summary>
        /// Next page token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of model definitions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelDefinitionsResponse" /> class.
        /// </summary>
        /// <param name="modelDefinitions">
        /// A list of model definition resources.
        /// </param>
        /// <param name="nextPageToken">
        /// Next page token.
        /// </param>
        /// <param name="totalSize">
        /// Total number of model definitions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListModelDefinitionsResponse(
            global::System.Collections.Generic.IList<global::G.ModelDefinition>? modelDefinitions,
            string? nextPageToken,
            int? totalSize)
        {
            this.ModelDefinitions = modelDefinitions;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelDefinitionsResponse" /> class.
        /// </summary>
        public ListModelDefinitionsResponse()
        {
        }
    }
}