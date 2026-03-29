//HintName: G.Models.AttachFunctionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AttachFunctionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attached_function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AttachedFunctionInfo AttachedFunction { get; set; }

        /// <summary>
        /// True if newly created, false if already existed (idempotent request).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachFunctionResponse" /> class.
        /// </summary>
        /// <param name="attachedFunction"></param>
        /// <param name="created">
        /// True if newly created, false if already existed (idempotent request).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachFunctionResponse(
            global::G.AttachedFunctionInfo attachedFunction,
            bool created)
        {
            this.AttachedFunction = attachedFunction ?? throw new global::System.ArgumentNullException(nameof(attachedFunction));
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachFunctionResponse" /> class.
        /// </summary>
        public AttachFunctionResponse()
        {
        }
    }
}