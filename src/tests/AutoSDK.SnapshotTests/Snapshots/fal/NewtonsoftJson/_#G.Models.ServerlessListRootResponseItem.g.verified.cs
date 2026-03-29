//HintName: G.Models.ServerlessListRootResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File or folder specification
    /// </summary>
    public sealed partial class ServerlessListRootResponseItem
    {
        /// <summary>
        /// Full file or folder path<br/>
        /// Example: datasets/images/cat.jpg
        /// </summary>
        /// <example>datasets/images/cat.jpg</example>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Base name of the file or folder<br/>
        /// Example: cat.jpg
        /// </summary>
        /// <example>cat.jpg</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Creation timestamp (UTC ISO 8601)<br/>
        /// Example: 2024-11-08T00:00:00.000Z
        /// </summary>
        /// <example>2024-11-08T00:00:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedTime { get; set; } = default!;

        /// <summary>
        /// Last update timestamp (UTC ISO 8601)<br/>
        /// Example: 2024-11-09T00:00:00.000Z
        /// </summary>
        /// <example>2024-11-09T00:00:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedTime { get; set; } = default!;

        /// <summary>
        /// True if this item is a file, false if it is a folder<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("is_file", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsFile { get; set; } = default!;

        /// <summary>
        /// File size in bytes (0 for folders)<br/>
        /// Example: 1250023
        /// </summary>
        /// <example>1250023</example>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public double Size { get; set; } = default!;

        /// <summary>
        /// Optional SHA256 checksum<br/>
        /// Example: b1946ac92492d2347c6235b4d2611184d5c3f1f0f44aa7b27d3b1d5b0f5a6a11
        /// </summary>
        /// <example>b1946ac92492d2347c6235b4d2611184d5c3f1f0f44aa7b27d3b1d5b0f5a6a11</example>
        [global::Newtonsoft.Json.JsonProperty("checksum_sha256")]
        public string? ChecksumSha256 { get; set; }

        /// <summary>
        /// Optional MD5 checksum<br/>
        /// Example: 9e107d9d372bb6826bd81d3542a419d6
        /// </summary>
        /// <example>9e107d9d372bb6826bd81d3542a419d6</example>
        [global::Newtonsoft.Json.JsonProperty("checksum_md5")]
        public string? ChecksumMd5 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListRootResponseItem" /> class.
        /// </summary>
        /// <param name="path">
        /// Full file or folder path<br/>
        /// Example: datasets/images/cat.jpg
        /// </param>
        /// <param name="name">
        /// Base name of the file or folder<br/>
        /// Example: cat.jpg
        /// </param>
        /// <param name="createdTime">
        /// Creation timestamp (UTC ISO 8601)<br/>
        /// Example: 2024-11-08T00:00:00.000Z
        /// </param>
        /// <param name="updatedTime">
        /// Last update timestamp (UTC ISO 8601)<br/>
        /// Example: 2024-11-09T00:00:00.000Z
        /// </param>
        /// <param name="isFile">
        /// True if this item is a file, false if it is a folder<br/>
        /// Example: true
        /// </param>
        /// <param name="size">
        /// File size in bytes (0 for folders)<br/>
        /// Example: 1250023
        /// </param>
        /// <param name="checksumSha256">
        /// Optional SHA256 checksum<br/>
        /// Example: b1946ac92492d2347c6235b4d2611184d5c3f1f0f44aa7b27d3b1d5b0f5a6a11
        /// </param>
        /// <param name="checksumMd5">
        /// Optional MD5 checksum<br/>
        /// Example: 9e107d9d372bb6826bd81d3542a419d6
        /// </param>
        public ServerlessListRootResponseItem(
            string path,
            string name,
            global::System.DateTime createdTime,
            global::System.DateTime updatedTime,
            bool isFile,
            double size,
            string? checksumSha256,
            string? checksumMd5)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedTime = createdTime;
            this.UpdatedTime = updatedTime;
            this.IsFile = isFile;
            this.Size = size;
            this.ChecksumSha256 = checksumSha256;
            this.ChecksumMd5 = checksumMd5;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListRootResponseItem" /> class.
        /// </summary>
        public ServerlessListRootResponseItem()
        {
        }
    }
}