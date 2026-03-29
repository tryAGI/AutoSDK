//HintName: G.Models.CreateFileDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFileDTO
    {
        /// <summary>
        /// This is the File you want to upload for use with the Knowledge Base.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// This is the File you want to upload for use with the Knowledge Base.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileDTO" /> class.
        /// </summary>
        /// <param name="file">
        /// This is the File you want to upload for use with the Knowledge Base.
        /// </param>
        /// <param name="filename">
        /// This is the File you want to upload for use with the Knowledge Base.
        /// </param>
        public CreateFileDTO(
            byte[] file,
            string filename)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileDTO" /> class.
        /// </summary>
        public CreateFileDTO()
        {
        }
    }
}