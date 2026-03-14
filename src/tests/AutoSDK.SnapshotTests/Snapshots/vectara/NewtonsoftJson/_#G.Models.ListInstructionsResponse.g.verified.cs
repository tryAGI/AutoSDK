//HintName: G.Models.ListInstructionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of instructions.
    /// </summary>
    public sealed partial class ListInstructionsResponse
    {
        /// <summary>
        /// List of instructions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Instruction> Instructions { get; set; } = default!;

        /// <summary>
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </summary>
        /// <example>{"page_key":"eyJvZmZzZXQiOjF9"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ListMetadata Metadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListInstructionsResponse" /> class.
        /// </summary>
        /// <param name="instructions">
        /// List of instructions.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
        public ListInstructionsResponse(
            global::System.Collections.Generic.IList<global::G.Instruction> instructions,
            global::G.ListMetadata metadata)
        {
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListInstructionsResponse" /> class.
        /// </summary>
        public ListInstructionsResponse()
        {
        }
    }
}