//HintName: G.Models.SecretScanningLocationCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a 'commit' secret scanning location type. This location type shows that a secret was detected inside a commit to a repository.
    /// </summary>
    public sealed partial class SecretScanningLocationCommit
    {
        /// <summary>
        /// The file path in the repository<br/>
        /// Example: /example/secrets.txt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Line number at which the secret starts in the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartLine { get; set; }

        /// <summary>
        /// Line number at which the secret ends in the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndLine { get; set; }

        /// <summary>
        /// The column at which the secret starts within the start line when the file is interpreted as 8BIT ASCII
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartColumn { get; set; }

        /// <summary>
        /// The column at which the secret ends within the end line when the file is interpreted as 8BIT ASCII
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndColumn { get; set; }

        /// <summary>
        /// SHA-1 hash ID of the associated blob<br/>
        /// Example: af5626b4a114abcb82d63db7c8082c3c4756e51b
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blob_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlobSha { get; set; }

        /// <summary>
        /// The API URL to get the associated blob resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blob_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlobUrl { get; set; }

        /// <summary>
        /// SHA-1 hash ID of the associated commit<br/>
        /// Example: af5626b4a114abcb82d63db7c8082c3c4756e51b
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitSha { get; set; }

        /// <summary>
        /// The API URL to get the associated commit resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}