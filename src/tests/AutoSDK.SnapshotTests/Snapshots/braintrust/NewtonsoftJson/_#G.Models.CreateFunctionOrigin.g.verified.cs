//HintName: G.Models.CreateFunctionOrigin.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFunctionOrigin
    {
        /// <summary>
        /// The object type that the ACL applies to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AclObjectType ObjectType { get; set; } = default!;

        /// <summary>
        /// Id of the object the function is originating from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ObjectId { get; set; } = default!;

        /// <summary>
        /// The function exists for internal purposes and should not be displayed in the list of functions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("internal")]
        public bool? Internal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFunctionOrigin" /> class.
        /// </summary>
        /// <param name="objectType">
        /// The object type that the ACL applies to
        /// </param>
        /// <param name="objectId">
        /// Id of the object the function is originating from
        /// </param>
        /// <param name="internal">
        /// The function exists for internal purposes and should not be displayed in the list of functions.
        /// </param>
        public CreateFunctionOrigin(
            global::G.AclObjectType objectType,
            global::System.Guid objectId,
            bool? @internal)
        {
            this.ObjectType = objectType;
            this.ObjectId = objectId;
            this.Internal = @internal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFunctionOrigin" /> class.
        /// </summary>
        public CreateFunctionOrigin()
        {
        }
    }
}