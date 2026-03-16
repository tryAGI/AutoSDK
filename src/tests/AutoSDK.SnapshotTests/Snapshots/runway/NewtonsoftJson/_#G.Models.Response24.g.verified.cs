//HintName: G.Models.Response24.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response24
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ResponseResult> Results { get; set; } = default!;

        /// <summary>
        /// The list of models with usage during the queried time range.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ResponseModel> Models { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response24" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="models">
        /// The list of models with usage during the queried time range.
        /// </param>
        public Response24(
            global::System.Collections.Generic.IList<global::G.ResponseResult> results,
            global::System.Collections.Generic.IList<global::G.ResponseModel> models)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response24" /> class.
        /// </summary>
        public Response24()
        {
        }
    }
}