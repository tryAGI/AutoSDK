//HintName: G.Models.DeleteView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteView
    {
        /// <summary>
        /// The object type that the ACL applies to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AclObjectTypeJsonConverter))]
        public global::G.AclObjectType ObjectType { get; set; } = default!;

        /// <summary>
        /// The id of the object the view applies to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ObjectId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteView" /> class.
        /// </summary>
        /// <param name="objectType">
        /// The object type that the ACL applies to
        /// </param>
        /// <param name="objectId">
        /// The id of the object the view applies to
        /// </param>
        public DeleteView(
            global::G.AclObjectType objectType,
            global::System.Guid objectId)
        {
            this.ObjectType = objectType;
            this.ObjectId = objectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteView" /> class.
        /// </summary>
        public DeleteView()
        {
        }
    }
}