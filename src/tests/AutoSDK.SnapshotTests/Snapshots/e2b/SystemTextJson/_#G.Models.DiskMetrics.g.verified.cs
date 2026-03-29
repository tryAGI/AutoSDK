//HintName: G.Models.DiskMetrics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiskMetrics
    {
        /// <summary>
        /// Mount point of the disk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mountPoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountPoint { get; set; }

        /// <summary>
        /// Device name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Device { get; set; }

        /// <summary>
        /// Filesystem type (e.g., ext4, xfs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filesystemType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FilesystemType { get; set; }

        /// <summary>
        /// Used space in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UsedBytes { get; set; }

        /// <summary>
        /// Total space in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalBytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskMetrics" /> class.
        /// </summary>
        /// <param name="mountPoint">
        /// Mount point of the disk
        /// </param>
        /// <param name="device">
        /// Device name
        /// </param>
        /// <param name="filesystemType">
        /// Filesystem type (e.g., ext4, xfs)
        /// </param>
        /// <param name="usedBytes">
        /// Used space in bytes
        /// </param>
        /// <param name="totalBytes">
        /// Total space in bytes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiskMetrics(
            string mountPoint,
            string device,
            string filesystemType,
            int usedBytes,
            int totalBytes)
        {
            this.MountPoint = mountPoint ?? throw new global::System.ArgumentNullException(nameof(mountPoint));
            this.Device = device ?? throw new global::System.ArgumentNullException(nameof(device));
            this.FilesystemType = filesystemType ?? throw new global::System.ArgumentNullException(nameof(filesystemType));
            this.UsedBytes = usedBytes;
            this.TotalBytes = totalBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiskMetrics" /> class.
        /// </summary>
        public DiskMetrics()
        {
        }
    }
}