//HintName: G.Models.ModelsCountResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model count data
    /// </summary>
    public sealed partial class ModelsCountResponse
    {
        /// <summary>
        /// Model count data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelsCountResponseData Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCountResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Model count data
        /// </param>
        public ModelsCountResponse(
            global::G.ModelsCountResponseData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCountResponse" /> class.
        /// </summary>
        public ModelsCountResponse()
        {
        }
    }
}