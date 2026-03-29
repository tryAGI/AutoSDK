//HintName: G.Models.UpdateFolderRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateFolderRequest
    {
        /// <summary>
        /// The new name for the folder. Must be unique within its parent folder.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFolderRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The new name for the folder. Must be unique within its parent folder.
        /// </param>
        public UpdateFolderRequest(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFolderRequest" /> class.
        /// </summary>
        public UpdateFolderRequest()
        {
        }
    }
}