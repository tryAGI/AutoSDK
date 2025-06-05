//HintName: G.Models.BodyOpenaiFilesV1OpenaiFilesPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyOpenaiFilesV1OpenaiFilesPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("purpose", Required = global::Newtonsoft.Json.Required.Always)]
        public string Purpose { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<byte[]> File { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyOpenaiFilesV1OpenaiFilesPost" /> class.
        /// </summary>
        /// <param name="purpose"></param>
        /// <param name="file"></param>
        public BodyOpenaiFilesV1OpenaiFilesPost(
            string purpose,
            global::System.Collections.Generic.IList<byte[]> file)
        {
            this.Purpose = purpose ?? throw new global::System.ArgumentNullException(nameof(purpose));
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyOpenaiFilesV1OpenaiFilesPost" /> class.
        /// </summary>
        public BodyOpenaiFilesV1OpenaiFilesPost()
        {
        }
    }
}