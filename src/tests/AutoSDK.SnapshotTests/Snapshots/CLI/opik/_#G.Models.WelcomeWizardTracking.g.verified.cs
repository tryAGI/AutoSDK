//HintName: G.Models.WelcomeWizardTracking.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WelcomeWizardTracking
    {
        /// <summary>
        /// Whether the welcome wizard has been completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        public bool? Completed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WelcomeWizardTracking" /> class.
        /// </summary>
        /// <param name="completed">
        /// Whether the welcome wizard has been completed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WelcomeWizardTracking(
            bool? completed)
        {
            this.Completed = completed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WelcomeWizardTracking" /> class.
        /// </summary>
        public WelcomeWizardTracking()
        {
        }
    }
}