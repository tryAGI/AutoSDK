//HintName: G.Models.InstructionReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A reference to an instruction that can be used by an agent. If version is not specified, the latest version will be used. Note that when the instruction is updated, agents using it will need to be updated to reference the new version explicitly.
    /// </summary>
    public sealed partial class InstructionReference
    {
        /// <summary>
        /// The unique identifier for an instruction.<br/>
        /// Example: ins_customer_support_init
        /// </summary>
        /// <example>ins_customer_support_init</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The specific version of the instruction to use. If not specified, the latest version will be used.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstructionReference" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for an instruction.<br/>
        /// Example: ins_customer_support_init
        /// </param>
        /// <param name="version">
        /// The specific version of the instruction to use. If not specified, the latest version will be used.<br/>
        /// Example: 1
        /// </param>
        public InstructionReference(
            string id,
            int? version)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstructionReference" /> class.
        /// </summary>
        public InstructionReference()
        {
        }
    }
}