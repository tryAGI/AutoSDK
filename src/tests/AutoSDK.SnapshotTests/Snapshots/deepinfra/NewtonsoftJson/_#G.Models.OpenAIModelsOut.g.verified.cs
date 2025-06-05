//HintName: G.Models.OpenAIModelsOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIModelsOut
    {
        /// <summary>
        /// Default Value: list
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.OpenAIModelOut>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIModelsOut" /> class.
        /// </summary>
        /// <param name="object">
        /// Default Value: list
        /// </param>
        /// <param name="data"></param>
        public OpenAIModelsOut(
            string? @object,
            global::System.Collections.Generic.IList<global::G.OpenAIModelOut>? data)
        {
            this.Object = @object;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIModelsOut" /> class.
        /// </summary>
        public OpenAIModelsOut()
        {
        }
    }
}