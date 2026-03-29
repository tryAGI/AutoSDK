//HintName: G.Models.CreateTaskResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskResponse
    {
        /// <summary>
        /// The ID of the created task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        public string Result { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskResponse" /> class.
        /// </summary>
        /// <param name="result">
        /// The ID of the created task
        /// </param>
        public CreateTaskResponse(
            string result)
        {
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskResponse" /> class.
        /// </summary>
        public CreateTaskResponse()
        {
        }
    }
}