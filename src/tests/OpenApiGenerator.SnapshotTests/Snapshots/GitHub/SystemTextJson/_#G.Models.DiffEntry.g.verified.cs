//HintName: G.Models.DiffEntry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Diff Entry
    /// </summary>
    public sealed partial class DiffEntry
    {
        /// <summary>
        /// <br/>Example: bbcd538c8e72b8c175046e27cc8f907076331401
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// <br/>Example: file1.txt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// <br/>Example: added
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.DiffEntryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required DiffEntryStatus Status { get; set; }

        /// <summary>
        /// <br/>Example: 103
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Additions { get; set; }

        /// <summary>
        /// <br/>Example: 21
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Deletions { get; set; }

        /// <summary>
        /// <br/>Example: 124
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Changes { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/octocat/Hello-World/blob/6dcb09b5b57875f334f61aebed695e2e4193db5e/file1.txt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blob_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlobUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/octocat/Hello-World/raw/6dcb09b5b57875f334f61aebed695e2e4193db5e/file1.txt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RawUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/octocat/Hello-World/contents/file1.txt?ref=6dcb09b5b57875f334f61aebed695e2e4193db5e
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentsUrl { get; set; }

        /// <summary>
        /// <br/>Example: @@ -132,7 +132,7 @@ module Test @@ -1000,7 +1000,7 @@ module Test
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch")]
        public string? Patch { get; set; }

        /// <summary>
        /// <br/>Example: file.txt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_filename")]
        public string? PreviousFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}