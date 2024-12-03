//HintName: G.Models.CreatePollBodyChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePollBodyChoice
    {
        /// <summary>
        /// One of the choices the viewer may select. The choice may contain a maximum of 25 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePollBodyChoice" /> class.
        /// </summary>
        /// <param name="title">
        /// One of the choices the viewer may select. The choice may contain a maximum of 25 characters.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreatePollBodyChoice(
            string title)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePollBodyChoice" /> class.
        /// </summary>
        public CreatePollBodyChoice()
        {
        }
    }
}