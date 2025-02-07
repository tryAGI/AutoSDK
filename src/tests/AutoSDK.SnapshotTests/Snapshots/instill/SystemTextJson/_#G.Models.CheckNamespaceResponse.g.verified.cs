//HintName: G.Models.CheckNamespaceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CheckNamespaceResponse contains the availability of a namespace or the type<br/>
    /// of resource that's using it.
    /// </summary>
    public sealed partial class CheckNamespaceResponse
    {
        /// <summary>
        /// Namespace type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CheckNamespaceResponseNamespaceJsonConverter))]
        public global::G.CheckNamespaceResponseNamespace? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckNamespaceResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Namespace type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckNamespaceResponse(
            global::G.CheckNamespaceResponseNamespace? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckNamespaceResponse" /> class.
        /// </summary>
        public CheckNamespaceResponse()
        {
        }
    }
}