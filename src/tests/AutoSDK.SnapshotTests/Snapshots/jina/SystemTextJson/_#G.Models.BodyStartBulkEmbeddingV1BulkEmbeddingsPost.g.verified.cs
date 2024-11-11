//HintName: G.Models.BodyStartBulkEmbeddingV1BulkEmbeddingsPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyStartBulkEmbeddingV1BulkEmbeddingsPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyStartBulkEmbeddingV1BulkEmbeddingsPost" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="email"></param>
        /// <param name="model"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BodyStartBulkEmbeddingV1BulkEmbeddingsPost(
            byte[] file,
            string filename,
            string model,
            string? email)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyStartBulkEmbeddingV1BulkEmbeddingsPost" /> class.
        /// </summary>
        public BodyStartBulkEmbeddingV1BulkEmbeddingsPost()
        {
        }
    }
}