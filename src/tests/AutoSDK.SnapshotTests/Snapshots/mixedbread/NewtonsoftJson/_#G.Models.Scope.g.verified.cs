//HintName: G.Models.Scope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Scope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScopeMethod Method { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_id")]
        public global::G.AnyOf<string, global::System.Guid?, object>? ResourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Scope" /> class.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="resourceType"></param>
        /// <param name="resourceId"></param>
        public Scope(
            global::G.ScopeMethod method,
            string? resourceType,
            global::G.AnyOf<string, global::System.Guid?, object>? resourceId)
        {
            this.Method = method;
            this.ResourceType = resourceType;
            this.ResourceId = resourceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Scope" /> class.
        /// </summary>
        public Scope()
        {
        }
    }
}