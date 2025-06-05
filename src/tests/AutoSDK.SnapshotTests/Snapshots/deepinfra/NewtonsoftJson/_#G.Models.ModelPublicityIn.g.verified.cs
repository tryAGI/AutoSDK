//HintName: G.Models.ModelPublicityIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPublicityIn
    {
        /// <summary>
        /// whether to make the model public of private
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Public { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPublicityIn" /> class.
        /// </summary>
        /// <param name="public">
        /// whether to make the model public of private
        /// </param>
        public ModelPublicityIn(
            bool @public)
        {
            this.Public = @public;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPublicityIn" /> class.
        /// </summary>
        public ModelPublicityIn()
        {
        }
    }
}