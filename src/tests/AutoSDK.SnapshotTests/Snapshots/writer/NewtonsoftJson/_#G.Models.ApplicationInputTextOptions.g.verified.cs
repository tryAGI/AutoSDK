//HintName: G.Models.ApplicationInputTextOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options specific to text input fields.
    /// </summary>
    public sealed partial class ApplicationInputTextOptions
    {
        /// <summary>
        /// Maximum number of text fields allowed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_fields", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxFields { get; set; } = default!;

        /// <summary>
        /// Minimum number of text fields required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_fields", Required = global::Newtonsoft.Json.Required.Always)]
        public int MinFields { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInputTextOptions" /> class.
        /// </summary>
        /// <param name="maxFields">
        /// Maximum number of text fields allowed.
        /// </param>
        /// <param name="minFields">
        /// Minimum number of text fields required.
        /// </param>
        public ApplicationInputTextOptions(
            int maxFields,
            int minFields)
        {
            this.MaxFields = maxFields;
            this.MinFields = minFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInputTextOptions" /> class.
        /// </summary>
        public ApplicationInputTextOptions()
        {
        }
    }
}