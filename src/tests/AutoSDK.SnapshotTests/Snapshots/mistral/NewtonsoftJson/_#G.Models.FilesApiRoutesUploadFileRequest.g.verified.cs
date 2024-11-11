//HintName: G.Models.FilesApiRoutesUploadFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilesApiRoutesUploadFileRequest
    {
        /// <summary>
        /// The File object (not file name) to be uploaded.<br/>
        ///  To upload a file and specify a custom file name you should format your request as such:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl;filename=custom_name.jsonl<br/>
        ///  ```<br/>
        ///  Otherwise, you can just keep the original file name:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl<br/>
        ///  ```
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// The File object (not file name) to be uploaded.<br/>
        ///  To upload a file and specify a custom file name you should format your request as such:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl;filename=custom_name.jsonl<br/>
        ///  ```<br/>
        ///  Otherwise, you can just keep the original file name:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl<br/>
        ///  ```
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Default Value: fine-tune
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("purpose")]
        public global::G.FilesApiRoutesUploadFileRequestPurpose? Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesApiRoutesUploadFileRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// The File object (not file name) to be uploaded.<br/>
        ///  To upload a file and specify a custom file name you should format your request as such:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl;filename=custom_name.jsonl<br/>
        ///  ```<br/>
        ///  Otherwise, you can just keep the original file name:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl<br/>
        ///  ```
        /// </param>
        /// <param name="filename">
        /// The File object (not file name) to be uploaded.<br/>
        ///  To upload a file and specify a custom file name you should format your request as such:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl;filename=custom_name.jsonl<br/>
        ///  ```<br/>
        ///  Otherwise, you can just keep the original file name:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl<br/>
        ///  ```
        /// </param>
        /// <param name="purpose">
        /// Default Value: fine-tune
        /// </param>
        public FilesApiRoutesUploadFileRequest(
            byte[] file,
            string filename,
            global::G.FilesApiRoutesUploadFileRequestPurpose? purpose)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesApiRoutesUploadFileRequest" /> class.
        /// </summary>
        public FilesApiRoutesUploadFileRequest()
        {
        }
    }
}