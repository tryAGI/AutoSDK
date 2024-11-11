//HintName: G.Models.Spec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Spec represents a specification data model.
    /// </summary>
    public sealed partial class Spec
    {
        /// <summary>
        /// Component specification.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("componentSpecification", Required = global::Newtonsoft.Json.Required.Always)]
        public object ComponentSpecification { get; set; } = default!;

        /// <summary>
        /// Data specifications.<br/>
        /// The key represents the task, and the value is the corresponding data_specification.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataSpecifications", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.DataSpecification> DataSpecifications { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Spec" /> class.
        /// </summary>
        /// <param name="componentSpecification">
        /// Component specification.
        /// </param>
        /// <param name="dataSpecifications">
        /// Data specifications.<br/>
        /// The key represents the task, and the value is the corresponding data_specification.
        /// </param>
        public Spec(
            object componentSpecification,
            global::System.Collections.Generic.Dictionary<string, global::G.DataSpecification> dataSpecifications)
        {
            this.ComponentSpecification = componentSpecification ?? throw new global::System.ArgumentNullException(nameof(componentSpecification));
            this.DataSpecifications = dataSpecifications ?? throw new global::System.ArgumentNullException(nameof(dataSpecifications));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Spec" /> class.
        /// </summary>
        public Spec()
        {
        }
    }
}