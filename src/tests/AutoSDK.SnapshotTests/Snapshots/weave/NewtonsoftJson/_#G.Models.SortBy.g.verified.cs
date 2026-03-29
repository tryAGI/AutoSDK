//HintName: G.Models.SortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SortBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field", Required = global::Newtonsoft.Json.Required.Always)]
        public string Field { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("direction", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SortByDirection Direction { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SortBy" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="direction"></param>
        public SortBy(
            string field,
            global::G.SortByDirection direction)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortBy" /> class.
        /// </summary>
        public SortBy()
        {
        }
    }
}