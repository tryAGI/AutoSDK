//HintName: G.Models.AdminApiKeysCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminApiKeysCreateRequest
    {
        /// <summary>
        /// Example: New Admin Key
        /// </summary>
        /// <example>New Admin Key</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeysCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: New Admin Key
        /// </param>
        public AdminApiKeysCreateRequest(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeysCreateRequest" /> class.
        /// </summary>
        public AdminApiKeysCreateRequest()
        {
        }
    }
}