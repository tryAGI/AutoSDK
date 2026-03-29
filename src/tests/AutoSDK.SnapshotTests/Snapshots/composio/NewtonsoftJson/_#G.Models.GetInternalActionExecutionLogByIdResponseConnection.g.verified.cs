//HintName: G.Models.GetInternalActionExecutionLogByIdResponseConnection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInternalActionExecutionLogByIdResponseConnection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity", Required = global::Newtonsoft.Json.Required.Always)]
        public string Entity { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseConnection" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        public GetInternalActionExecutionLogByIdResponseConnection(
            string id,
            string entity)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Entity = entity ?? throw new global::System.ArgumentNullException(nameof(entity));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponseConnection" /> class.
        /// </summary>
        public GetInternalActionExecutionLogByIdResponseConnection()
        {
        }
    }
}