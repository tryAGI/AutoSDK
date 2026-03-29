//HintName: G.Models.ModelsListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of available models
    /// </summary>
    public sealed partial class ModelsListResponse
    {
        /// <summary>
        /// List of available models
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Model> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of available models
        /// </param>
        public ModelsListResponse(
            global::System.Collections.Generic.IList<global::G.Model> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsListResponse" /> class.
        /// </summary>
        public ModelsListResponse()
        {
        }
    }
}