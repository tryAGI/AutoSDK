//HintName: G.Models.AddUploadPartRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddUploadPartRequest
    {
        /// <summary>
        /// The chunk of bytes for this Part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Data { get; set; }

        /// <summary>
        /// The chunk of bytes for this Part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dataname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}