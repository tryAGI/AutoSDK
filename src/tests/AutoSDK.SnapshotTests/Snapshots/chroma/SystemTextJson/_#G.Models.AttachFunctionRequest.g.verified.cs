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
        [global::System.Text.Json.Serialization.JsonPropertyName("function_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputCollection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachFunctionRequest" /> class.
        /// </summary>
        /// <param name="functionId"></param>
        /// <param name="name"></param>
        /// <param name="outputCollection"></param>
        /// <param name="params"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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