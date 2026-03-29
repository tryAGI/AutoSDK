//HintName: G.Models.InsertedSpanAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsertedSpanAnnotation
    {
        /// <summary>
        /// The ID of the inserted span annotation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertedSpanAnnotation" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the inserted span annotation
        /// </param>
        public InsertedSpanAnnotation(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsertedSpanAnnotation" /> class.
        /// </summary>
        public InsertedSpanAnnotation()
        {
        }
    }
}