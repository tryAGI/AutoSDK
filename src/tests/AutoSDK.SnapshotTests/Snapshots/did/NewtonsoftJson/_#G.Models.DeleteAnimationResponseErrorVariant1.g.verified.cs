//HintName: G.Models.DeleteAnimationResponseErrorVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteAnimationResponseErrorVariant1
    {
        /// <summary>
        /// Default Value: DriverError
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Default Value: Driver provided is invalid or cannot be loaded
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAnimationResponseErrorVariant1" /> class.
        /// </summary>
        /// <param name="kind">
        /// Default Value: DriverError
        /// </param>
        /// <param name="description">
        /// Default Value: Driver provided is invalid or cannot be loaded
        /// </param>
        public DeleteAnimationResponseErrorVariant1(
            string? kind,
            string? description)
        {
            this.Kind = kind;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAnimationResponseErrorVariant1" /> class.
        /// </summary>
        public DeleteAnimationResponseErrorVariant1()
        {
        }
    }
}