//HintName: G.Models.UnknownError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnknownError
    {
        /// <summary>
        /// Default Value: UnknownError
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Default Value: Unknown internal error
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnknownError" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: UnknownError
        /// </param>
        /// <param name="description">
        /// Default Value: Unknown internal error
        /// </param>
        public UnknownError(
            string? kind,
            string? description)
        {
            this.Kind = kind;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnknownError" /> class.
        /// </summary>
        public UnknownError()
        {
        }
    }
}