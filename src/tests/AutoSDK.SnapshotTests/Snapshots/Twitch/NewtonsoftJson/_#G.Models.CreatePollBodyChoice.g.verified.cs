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
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePollBodyChoice" /> class.
        /// </summary>
        /// <param name="title">
        /// One of the choices the viewer may select. The choice may contain a maximum of 25 characters.
        /// </param>
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