//HintName: G.Models.PorterLargeFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Porter Large File
    /// </summary>
    public sealed partial class PorterLargeFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string RefName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("oid", Required = global::Newtonsoft.Json.Required.Always)]
        public string Oid { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PorterLargeFile" /> class.
        /// </summary>
        /// <param name="refName"></param>
        /// <param name="path"></param>
        /// <param name="oid"></param>
        /// <param name="size"></param>
        public PorterLargeFile(
            string refName,
            string path,
            string oid,
            int size)
        {
            this.RefName = refName ?? throw new global::System.ArgumentNullException(nameof(refName));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Oid = oid ?? throw new global::System.ArgumentNullException(nameof(oid));
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PorterLargeFile" /> class.
        /// </summary>
        public PorterLargeFile()
        {
        }
    }
}