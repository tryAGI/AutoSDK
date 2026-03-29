//HintName: G.Models.CreateFolderSuccessResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFolderSuccessResponse
    {
        /// <summary>
        /// Indicates if the operation was successful
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder")]
        public global::G.Folder? Folder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolderSuccessResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates if the operation was successful
        /// </param>
        /// <param name="folder"></param>
        public CreateFolderSuccessResponse(
            bool? success,
            global::G.Folder? folder)
        {
            this.Success = success;
            this.Folder = folder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolderSuccessResponse" /> class.
        /// </summary>
        public CreateFolderSuccessResponse()
        {
        }
    }
}