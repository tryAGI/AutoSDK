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
        [global::Newtonsoft.Json.JsonProperty("attached_function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AttachedFunctionInfo AttachedFunction { get; set; } = default!;

        /// <summary>
        /// True if newly created, false if already existed (idempotent request).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Created { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachFunctionResponse" /> class.
        /// </summary>
        /// <param name="attachedFunction"></param>
        /// <param name="created">
        /// True if newly created, false if already existed (idempotent request).
        /// </param>
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