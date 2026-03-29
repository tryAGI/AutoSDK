//HintName: G.Models.CreateResponseVariant1Error.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error object in case of errors
    /// </summary>
    public sealed partial class CreateResponseVariant1Error
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public string? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind", Required = global::Newtonsoft.Json.Required.Always)]
        public string Kind { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant1Error" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="kind"></param>
        /// <param name="details"></param>
        public CreateResponseVariant1Error(
            string description,
            string kind,
            string? details)
        {
            this.Details = details;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant1Error" /> class.
        /// </summary>
        public CreateResponseVariant1Error()
        {
        }
    }
}