//HintName: G.Models.DeleteModelOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteModelOut
    {
        /// <summary>
        /// The deletion status<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// The ID of the deleted model.<br/>
        /// Example: ft:open-mistral-7b:587a6b29:20240514:7e773925
        /// </summary>
        /// <example>ft:open-mistral-7b:587a6b29:20240514:7e773925</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type that was deleted<br/>
        /// Default Value: model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteModelOut" /> class.
        /// </summary>
        /// <param name="deleted">
        /// The deletion status<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="id">
        /// The ID of the deleted model.<br/>
        /// Example: ft:open-mistral-7b:587a6b29:20240514:7e773925
        /// </param>
        /// <param name="object">
        /// The object type that was deleted<br/>
        /// Default Value: model
        /// </param>
        public DeleteModelOut(
            string id,
            bool? deleted,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteModelOut" /> class.
        /// </summary>
        public DeleteModelOut()
        {
        }
    }
}