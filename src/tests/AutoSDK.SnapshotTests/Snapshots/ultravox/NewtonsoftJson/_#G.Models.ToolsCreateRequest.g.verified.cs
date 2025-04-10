//HintName: G.Models.ToolsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsCreateRequest
    {
        /// <summary>
        /// An OpenAPI schema file in either JSON or YAML format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// An OpenAPI schema file in either JSON or YAML format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCreateRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// An OpenAPI schema file in either JSON or YAML format.
        /// </param>
        /// <param name="filename">
        /// An OpenAPI schema file in either JSON or YAML format.
        /// </param>
        public ToolsCreateRequest(
            byte[] file,
            string filename)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsCreateRequest" /> class.
        /// </summary>
        public ToolsCreateRequest()
        {
        }
    }
}