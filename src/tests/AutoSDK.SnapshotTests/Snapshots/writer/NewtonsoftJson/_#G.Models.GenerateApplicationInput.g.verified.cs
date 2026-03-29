//HintName: G.Models.GenerateApplicationInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateApplicationInput
    {
        /// <summary>
        /// The unique identifier for the input field from the application. All input types from the No-code application are supported (i.e. Text input, Dropdown, File upload, Image input). The identifier should be the name of the input type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The value for the input field. <br/>
        /// If the input type is "File upload", you must pass the `file_id` of an uploaded file. You cannot pass a file object directly. See the [file upload endpoint](https://dev.writer.com/api-reference/file-api/upload-files) for instructions on uploading files or the [list files endpoint](https://dev.writer.com/api-reference/file-api/get-all-files) for how to see a list of uploaded files and their IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationInput" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the input field from the application. All input types from the No-code application are supported (i.e. Text input, Dropdown, File upload, Image input). The identifier should be the name of the input type.
        /// </param>
        /// <param name="value">
        /// The value for the input field. <br/>
        /// If the input type is "File upload", you must pass the `file_id` of an uploaded file. You cannot pass a file object directly. See the [file upload endpoint](https://dev.writer.com/api-reference/file-api/upload-files) for instructions on uploading files or the [list files endpoint](https://dev.writer.com/api-reference/file-api/get-all-files) for how to see a list of uploaded files and their IDs.
        /// </param>
        public GenerateApplicationInput(
            string id,
            global::System.Collections.Generic.IList<string> value)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationInput" /> class.
        /// </summary>
        public GenerateApplicationInput()
        {
        }
    }
}