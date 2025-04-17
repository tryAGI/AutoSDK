//HintName: G.Models.ChatModerationRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatModerationRequest
    {
        /// <summary>
        /// Chat to classify
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.InputVariant2ItemItem>>> Input { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatModerationRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Chat to classify
        /// </param>
        /// <param name="model"></param>
        public ChatModerationRequest(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.InputVariant2ItemItem>>> input,
            string model)
        {
            this.Input = input;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatModerationRequest" /> class.
        /// </summary>
        public ChatModerationRequest()
        {
        }
    }
}