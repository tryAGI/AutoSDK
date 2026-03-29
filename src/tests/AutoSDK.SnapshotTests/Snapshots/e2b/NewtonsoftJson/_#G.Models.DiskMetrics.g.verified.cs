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
        [global::Newtonsoft.Json.JsonProperty("mountPoint", Required = global::Newtonsoft.Json.Required.Always)]
        public string MountPoint { get; set; } = default!;

        /// <summary>
        /// Device name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("device", Required = global::Newtonsoft.Json.Required.Always)]
        public string Device { get; set; } = default!;

        /// <summary>
        /// Filesystem type (e.g., ext4, xfs)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filesystemType", Required = global::Newtonsoft.Json.Required.Always)]
        public string FilesystemType { get; set; } = default!;

        /// <summary>
        /// Used space in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usedBytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int UsedBytes { get; set; } = default!;

        /// <summary>
        /// Total space in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalBytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalBytes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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