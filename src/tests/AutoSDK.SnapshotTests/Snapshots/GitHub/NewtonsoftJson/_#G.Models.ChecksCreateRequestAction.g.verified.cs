//HintName: G.Models.ChecksCreateRequestAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksCreateRequestAction
    {
        /// <summary>
        /// The text to be displayed on a button in the web UI. The maximum size is 20 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// A short explanation of what this action would do. The maximum size is 40 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// A reference for the action on the integrator's system. The maximum size is 20 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identifier", Required = global::Newtonsoft.Json.Required.Always)]
        public string Identifier { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateRequestAction" /> class.
        /// </summary>
        /// <param name="label">
        /// The text to be displayed on a button in the web UI. The maximum size is 20 characters.
        /// </param>
        /// <param name="description">
        /// A short explanation of what this action would do. The maximum size is 40 characters.
        /// </param>
        /// <param name="identifier">
        /// A reference for the action on the integrator's system. The maximum size is 20 characters.
        /// </param>
        public ChecksCreateRequestAction(
            string label,
            string description,
            string identifier)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksCreateRequestAction" /> class.
        /// </summary>
        public ChecksCreateRequestAction()
        {
        }
    }
}