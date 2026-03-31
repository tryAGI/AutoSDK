//HintName: G.Models.FunctionOrigin.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionOrigin
    {
        /// <summary>
        /// The object type that the ACL applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AclObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AclObjectType ObjectType { get; set; }

        /// <summary>
        /// Id of the object the function is originating from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ObjectId { get; set; }

        /// <summary>
        /// The function exists for internal purposes and should not be displayed in the list of functions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionOrigin" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionOrigin(
            global::G.AclObjectType objectType,
            global::System.Guid objectId,
            bool? @internal)
        {
            this.ObjectType = objectType;
            this.ObjectId = objectId;
            this.Internal = @internal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionOrigin" /> class.
        /// </summary>
        public FunctionOrigin()
        {
        }
    }
}