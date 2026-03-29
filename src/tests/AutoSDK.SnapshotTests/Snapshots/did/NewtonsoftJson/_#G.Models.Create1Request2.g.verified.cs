//HintName: G.Models.Create1Request2.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Construct a type with the properties of T except for those in type K.
    /// </summary>
    public sealed partial class Create1Request2
    {
        /// <summary>
        /// Description of knowledge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Name of knowledge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// List of messages to be showen as chat starter questions for the user to ask<br/>
        /// Use agent.starter_messages instead
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("starter_message")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? StarterMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Create1Request2" /> class.
        /// </summary>
        /// <param name="description">
        /// Description of knowledge
        /// </param>
        /// <param name="name">
        /// Name of knowledge
        /// </param>
        public Create1Request2(
            string description,
            string name)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Create1Request2" /> class.
        /// </summary>
        public Create1Request2()
        {
        }
    }
}