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
        /// The ID of the deleted model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type that was deleted<br/>
        /// Default Value: model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The deletion status<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteModelOut" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the deleted model.
        /// </param>
        /// <param name="object">
        /// The object type that was deleted<br/>
        /// Default Value: model
        /// </param>
        /// <param name="deleted">
        /// The deletion status<br/>
        /// Default Value: true
        /// </param>
        public DeleteModelOut(
            string id,
            string? @object,
            bool? deleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteModelOut" /> class.
        /// </summary>
        public DeleteModelOut()
        {
        }
    }
}