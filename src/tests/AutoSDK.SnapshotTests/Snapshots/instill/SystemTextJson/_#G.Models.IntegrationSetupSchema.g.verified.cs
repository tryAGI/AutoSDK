//HintName: G.Models.IntegrationSetupSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The connection setup field definitions. Each integration will require<br/>
    /// different data to connect to the 3rd party app.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class IntegrationSetupSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationSetupSchema" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public IntegrationSetupSchema(
 )
        {
        }
    }
}