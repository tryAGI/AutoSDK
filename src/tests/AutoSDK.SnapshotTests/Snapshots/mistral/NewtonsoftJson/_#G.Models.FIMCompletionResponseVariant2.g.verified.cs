//HintName: G.Models.FIMCompletionResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FIMCompletionResponseVariant2
    {
        /// <summary>
        /// Example: codestral-latest
        /// </summary>
        /// <example>codestral-latest</example>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FIMCompletionResponseVariant2" /> class.
        /// </summary>
        /// <param name="model">
        /// Example: codestral-latest
        /// </param>
        public FIMCompletionResponseVariant2(
            string? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FIMCompletionResponseVariant2" /> class.
        /// </summary>
        public FIMCompletionResponseVariant2()
        {
        }
    }
}