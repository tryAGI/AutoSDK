//HintName: G.Models.CreateAnimationResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAnimationResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind", Required = global::Newtonsoft.Json.Required.Always)]
        public string Kind { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public object? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("internal")]
        public string? Internal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnimationResponse3" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="description"></param>
        /// <param name="details"></param>
        /// <param name="internal"></param>
        public CreateAnimationResponse3(
            string kind,
            string description,
            object? details,
            string? @internal)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Details = details;
            this.Internal = @internal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnimationResponse3" /> class.
        /// </summary>
        public CreateAnimationResponse3()
        {
        }
    }
}