//HintName: G.Models.CreateTaskRequestVariant3File.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant3File
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant3File" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="fileToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTaskRequestVariant3File(
            string type,
            string fileToken)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.FileToken = fileToken ?? throw new global::System.ArgumentNullException(nameof(fileToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant3File" /> class.
        /// </summary>
        public CreateTaskRequestVariant3File()
        {
        }
    }
}