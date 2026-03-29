//HintName: G.Models.CreateTaskRequestVariant2File.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant2File
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant2File" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="fileToken"></param>
        public CreateTaskRequestVariant2File(
            string type,
            string fileToken)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.FileToken = fileToken ?? throw new global::System.ArgumentNullException(nameof(fileToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant2File" /> class.
        /// </summary>
        public CreateTaskRequestVariant2File()
        {
        }
    }
}