//HintName: G.Models.CreatePromptRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePromptRequest
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RecordStringAny Metadata { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public object Prompt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userDefinedId", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserDefinedId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="userDefinedId"></param>
        public CreatePromptRequest(
            global::G.RecordStringAny metadata,
            object prompt,
            string userDefinedId)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.UserDefinedId = userDefinedId ?? throw new global::System.ArgumentNullException(nameof(userDefinedId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptRequest" /> class.
        /// </summary>
        public CreatePromptRequest()
        {
        }
    }
}