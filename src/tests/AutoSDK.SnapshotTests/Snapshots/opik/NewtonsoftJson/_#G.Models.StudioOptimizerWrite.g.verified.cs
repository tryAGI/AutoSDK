//HintName: G.Models.StudioOptimizerWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StudioOptimizerWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.JsonNodeWrite? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioOptimizerWrite" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        public StudioOptimizerWrite(
            string type,
            global::G.JsonNodeWrite? parameters)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioOptimizerWrite" /> class.
        /// </summary>
        public StudioOptimizerWrite()
        {
        }
    }
}