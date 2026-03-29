//HintName: G.Models.TranscriptPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptPlan
    {
        /// <summary>
        /// This determines whether the transcript is stored in `call.artifact.transcript`. Defaults to true.<br/>
        /// @default true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This is the name of the assistant in the transcript. Defaults to 'AI'.<br/>
        /// Usage:<br/>
        /// - If you want to change the name of the assistant in the transcript, set this. Example, here is what the transcript would look like with `assistantName` set to 'Buyer':<br/>
        /// ```<br/>
        /// User: Hello, how are you?<br/>
        /// Buyer: I'm fine.<br/>
        /// User: Do you want to buy a car?<br/>
        /// Buyer: No.<br/>
        /// ```<br/>
        /// @default 'AI'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantName")]
        public string? AssistantName { get; set; }

        /// <summary>
        /// This is the name of the user in the transcript. Defaults to 'User'.<br/>
        /// Usage:<br/>
        /// - If you want to change the name of the user in the transcript, set this. Example, here is what the transcript would look like with `userName` set to 'Seller':<br/>
        /// ```<br/>
        /// Seller: Hello, how are you?<br/>
        /// AI: I'm fine.<br/>
        /// Seller: Do you want to buy a car?<br/>
        /// AI: No.<br/>
        /// ```<br/>
        /// @default 'User'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptPlan" /> class.
        /// </summary>
        /// <param name="enabled">
        /// This determines whether the transcript is stored in `call.artifact.transcript`. Defaults to true.<br/>
        /// @default true<br/>
        /// Example: true
        /// </param>
        /// <param name="assistantName">
        /// This is the name of the assistant in the transcript. Defaults to 'AI'.<br/>
        /// Usage:<br/>
        /// - If you want to change the name of the assistant in the transcript, set this. Example, here is what the transcript would look like with `assistantName` set to 'Buyer':<br/>
        /// ```<br/>
        /// User: Hello, how are you?<br/>
        /// Buyer: I'm fine.<br/>
        /// User: Do you want to buy a car?<br/>
        /// Buyer: No.<br/>
        /// ```<br/>
        /// @default 'AI'
        /// </param>
        /// <param name="userName">
        /// This is the name of the user in the transcript. Defaults to 'User'.<br/>
        /// Usage:<br/>
        /// - If you want to change the name of the user in the transcript, set this. Example, here is what the transcript would look like with `userName` set to 'Seller':<br/>
        /// ```<br/>
        /// Seller: Hello, how are you?<br/>
        /// AI: I'm fine.<br/>
        /// Seller: Do you want to buy a car?<br/>
        /// AI: No.<br/>
        /// ```<br/>
        /// @default 'User'
        /// </param>
        public TranscriptPlan(
            bool? enabled,
            string? assistantName,
            string? userName)
        {
            this.Enabled = enabled;
            this.AssistantName = assistantName;
            this.UserName = userName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptPlan" /> class.
        /// </summary>
        public TranscriptPlan()
        {
        }
    }
}