//HintName: G.Models.PromptOptionsNullish.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOptionsNullish
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params")]
        public global::G.ModelParams? Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public string? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptionsNullish" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="params"></param>
        /// <param name="position"></param>
        public PromptOptionsNullish(
            string? model,
            global::G.ModelParams? @params,
            string? position)
        {
            this.Model = model;
            this.Params = @params;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOptionsNullish" /> class.
        /// </summary>
        public PromptOptionsNullish()
        {
        }
    }
}