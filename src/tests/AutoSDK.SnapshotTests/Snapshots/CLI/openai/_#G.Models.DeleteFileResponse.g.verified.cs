﻿//HintName: G.Models.DeleteFileResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteFileResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeleteFileResponseObjectJsonConverter))]
        public global::G.DeleteFileResponseObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFileResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="deleted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteFileResponse(
            string id,
            bool deleted,
            global::G.DeleteFileResponseObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFileResponse" /> class.
        /// </summary>
        public DeleteFileResponse()
        {
        }
    }
}