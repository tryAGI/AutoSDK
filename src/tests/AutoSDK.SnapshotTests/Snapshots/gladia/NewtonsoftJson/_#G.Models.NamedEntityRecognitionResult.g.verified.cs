//HintName: G.Models.NamedEntityRecognitionResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NamedEntityRecognitionResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string EntityType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public double End { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedEntityRecognitionResult" /> class.
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="text"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public NamedEntityRecognitionResult(
            string entityType,
            string text,
            double start,
            double end)
        {
            this.EntityType = entityType ?? throw new global::System.ArgumentNullException(nameof(entityType));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedEntityRecognitionResult" /> class.
        /// </summary>
        public NamedEntityRecognitionResult()
        {
        }
    }
}