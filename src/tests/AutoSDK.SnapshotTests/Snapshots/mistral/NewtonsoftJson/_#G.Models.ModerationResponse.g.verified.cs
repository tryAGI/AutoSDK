//HintName: G.Models.ModerationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationResponse
    {
        /// <summary>
        /// Example: mod-e5cc70bb28c444948073e77776eb30ef
        /// </summary>
        /// <example>mod-e5cc70bb28c444948073e77776eb30ef</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModerationObject> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: mod-e5cc70bb28c444948073e77776eb30ef
        /// </param>
        /// <param name="model"></param>
        /// <param name="results"></param>
        public ModerationResponse(
            string id,
            string model,
            global::System.Collections.Generic.IList<global::G.ModerationObject> results)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationResponse" /> class.
        /// </summary>
        public ModerationResponse()
        {
        }
    }
}