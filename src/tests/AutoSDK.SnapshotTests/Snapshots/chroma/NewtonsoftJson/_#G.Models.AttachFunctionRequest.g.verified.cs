//HintName: G.Models.AttachFunctionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AttachFunctionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FunctionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_collection", Required = global::Newtonsoft.Json.Required.Always)]
        public string OutputCollection { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachFunctionRequest" /> class.
        /// </summary>
        /// <param name="functionId"></param>
        /// <param name="name"></param>
        /// <param name="outputCollection"></param>
        /// <param name="params"></param>
        public AttachFunctionRequest(
            string functionId,
            string name,
            string outputCollection,
            object? @params)
        {
            this.FunctionId = functionId ?? throw new global::System.ArgumentNullException(nameof(functionId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OutputCollection = outputCollection ?? throw new global::System.ArgumentNullException(nameof(outputCollection));
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachFunctionRequest" /> class.
        /// </summary>
        public AttachFunctionRequest()
        {
        }
    }
}