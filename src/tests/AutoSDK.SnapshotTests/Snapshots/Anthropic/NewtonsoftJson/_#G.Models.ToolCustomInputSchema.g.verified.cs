//HintName: G.Models.ToolCustomInputSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// [JSON schema](https://json-schema.org/) for this tool's input.<br/>
    /// This defines the shape of the `input` that your tool accepts and that the model<br/>
    /// will produce.
    /// </summary>
    public sealed partial class ToolCustomInputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCustomInputSchema" /> class.
        /// </summary>
        public ToolCustomInputSchema(
 )
        {
        }
    }
}