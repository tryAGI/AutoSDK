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
        [global::System.Text.Json.Serialization.JsonPropertyName("componentSpecification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ComponentSpecification { get; set; }

        /// <summary>
        /// Data specifications.<br/>
        /// The key represents the task, and the value is the corresponding data_specification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSpecifications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.DataSpecification> DataSpecifications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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