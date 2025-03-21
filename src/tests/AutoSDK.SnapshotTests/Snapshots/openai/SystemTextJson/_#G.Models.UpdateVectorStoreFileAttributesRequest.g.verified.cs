//HintName: G.Models.UpdateVectorStoreFileAttributesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateVectorStoreFileAttributesRequest
    {
        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be <br/>
        /// useful for storing additional information about the object in a structured <br/>
        /// format, and querying for objects via API or the dashboard. Keys are strings <br/>
        /// with a maximum length of 64 characters. Values are strings with a maximum <br/>
        /// length of 512 characters, booleans, or numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVectorStoreFileAttributesRequest" /> class.
        /// </summary>
        /// <param name="attributes">
        /// Set of 16 key-value pairs that can be attached to an object. This can be <br/>
        /// useful for storing additional information about the object in a structured <br/>
        /// format, and querying for objects via API or the dashboard. Keys are strings <br/>
        /// with a maximum length of 64 characters. Values are strings with a maximum <br/>
        /// length of 512 characters, booleans, or numbers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVectorStoreFileAttributesRequest(
            object? attributes)
        {
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVectorStoreFileAttributesRequest" /> class.
        /// </summary>
        public UpdateVectorStoreFileAttributesRequest()
        {
        }
    }
}