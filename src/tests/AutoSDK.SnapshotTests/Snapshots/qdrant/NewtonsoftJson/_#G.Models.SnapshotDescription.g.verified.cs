//HintName: G.Models.SnapshotDescription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"name":"my-collection-3766212330831337-2024-07-22-08-31-55.snapshot","creation_time":"2022-08-04T10:49:10","size":1000000,"checksum":"a1b2c3d4e5f6a7b8c9d0e1f2a3b4c5d6e7f8a9b0c1d2e3f4a5b6c7d8e9f0"}
    /// </summary>
    public sealed partial class SnapshotDescription
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_time")]
        public string? CreationTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("checksum")]
        public string? Checksum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotDescription" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="size"></param>
        /// <param name="creationTime"></param>
        /// <param name="checksum"></param>
        public SnapshotDescription(
            string name,
            int size,
            string? creationTime,
            string? checksum)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreationTime = creationTime;
            this.Size = size;
            this.Checksum = checksum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotDescription" /> class.
        /// </summary>
        public SnapshotDescription()
        {
        }
    }
}