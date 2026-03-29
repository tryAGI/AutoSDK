//HintName: G.Models.CreateAgentRequestPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentRequestPrompt
    {
        /// <summary>
        /// The task or instructions for the agent to execute<br/>
        /// Example: Add a README.md file with installation instructions
        /// </summary>
        /// <example>Add a README.md file with installation instructions</example>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Optional array of base64 encoded images (max 5)<br/>
        /// Example: [{"data":"iVBORw0KGgoAAAANSUhEUgAA...","dimension":{"width":1024,"height":768}}]
        /// </summary>
        /// <example>[{"data":"iVBORw0KGgoAAAANSUhEUgAA...","dimension":{"width":1024,"height":768}}]</example>
        [global::Newtonsoft.Json.JsonProperty("images")]
        public global::System.Collections.Generic.IList<global::G.Image>? Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequestPrompt" /> class.
        /// </summary>
        /// <param name="text">
        /// The task or instructions for the agent to execute<br/>
        /// Example: Add a README.md file with installation instructions
        /// </param>
        /// <param name="images">
        /// Optional array of base64 encoded images (max 5)<br/>
        /// Example: [{"data":"iVBORw0KGgoAAAANSUhEUgAA...","dimension":{"width":1024,"height":768}}]
        /// </param>
        public CreateAgentRequestPrompt(
            string text,
            global::System.Collections.Generic.IList<global::G.Image>? images)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Images = images;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequestPrompt" /> class.
        /// </summary>
        public CreateAgentRequestPrompt()
        {
        }
    }
}