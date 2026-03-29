//HintName: G.Models.GetInternalActionExecutionFieldsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetInternalActionExecutionFieldsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fields", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.GetInternalActionExecutionFieldsResponseField>> Fields { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionFieldsResponse" /> class.
        /// </summary>
        /// <param name="fields"></param>
        public GetInternalActionExecutionFieldsResponse(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.GetInternalActionExecutionFieldsResponseField>> fields)
        {
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionFieldsResponse" /> class.
        /// </summary>
        public GetInternalActionExecutionFieldsResponse()
        {
        }
    }
}