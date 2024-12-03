//HintName: G.Models.TrainingRequestInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object containing inputs to the Cog model's `train()` function.
    /// </summary>
    public sealed partial class TrainingRequestInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingRequestInput" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TrainingRequestInput(
 )
        {
        }
    }
}