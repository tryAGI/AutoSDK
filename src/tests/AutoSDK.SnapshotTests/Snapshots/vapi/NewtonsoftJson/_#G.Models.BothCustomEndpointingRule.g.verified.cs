//HintName: G.Models.BothCustomEndpointingRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BothCustomEndpointingRule
    {
        /// <summary>
        /// This endpointing rule is based on both the last assistant message and the current customer message as they are speaking.<br/>
        /// Flow:<br/>
        /// - Assistant speaks<br/>
        /// - Customer starts speaking<br/>
        /// - Customer transcription comes in<br/>
        /// - This rule is evaluated on the last assistant message and the current customer transcription<br/>
        /// - If assistant message matches `assistantRegex` AND customer message matches `customerRegex`, the endpointing timeout is set to `timeoutSeconds`<br/>
        /// Usage:<br/>
        /// - If you want to wait longer while customer is speaking numbers, you can set a longer timeout.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BothCustomEndpointingRuleType Type { get; set; }

        /// <summary>
        /// This is the regex pattern to match the assistant's message.<br/>
        /// Note:<br/>
        /// - This works by using the `RegExp.test` method in Node.JS. Eg. `/hello/.test("hello there")` will return `true`.<br/>
        /// Hot tip:<br/>
        /// - In JavaScript, escape `\` when sending the regex pattern. Eg. `"hello\sthere"` will be sent over the wire as `"hellosthere"`. Send `"hello\\sthere"` instead.<br/>
        /// - `RegExp.test` does substring matching, so `/cat/.test("I love cats")` will return `true`. To do full string matching, send "^cat$".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantRegex", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssistantRegex { get; set; } = default!;

        /// <summary>
        /// These are the options for the assistant's message regex match. Defaults to all disabled.<br/>
        /// @default []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantRegexOptions")]
        public global::System.Collections.Generic.IList<global::G.RegexOption>? AssistantRegexOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customerRegex", Required = global::Newtonsoft.Json.Required.Always)]
        public string CustomerRegex { get; set; } = default!;

        /// <summary>
        /// These are the options for the customer's message regex match. Defaults to all disabled.<br/>
        /// @default []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customerRegexOptions")]
        public global::System.Collections.Generic.IList<global::G.RegexOption>? CustomerRegexOptions { get; set; }

        /// <summary>
        /// This is the endpointing timeout in seconds, if the rule is matched.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeoutSeconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double TimeoutSeconds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BothCustomEndpointingRule" /> class.
        /// </summary>
        /// <param name="assistantRegex">
        /// This is the regex pattern to match the assistant's message.<br/>
        /// Note:<br/>
        /// - This works by using the `RegExp.test` method in Node.JS. Eg. `/hello/.test("hello there")` will return `true`.<br/>
        /// Hot tip:<br/>
        /// - In JavaScript, escape `\` when sending the regex pattern. Eg. `"hello\sthere"` will be sent over the wire as `"hellosthere"`. Send `"hello\\sthere"` instead.<br/>
        /// - `RegExp.test` does substring matching, so `/cat/.test("I love cats")` will return `true`. To do full string matching, send "^cat$".
        /// </param>
        /// <param name="customerRegex"></param>
        /// <param name="timeoutSeconds">
        /// This is the endpointing timeout in seconds, if the rule is matched.
        /// </param>
        /// <param name="type">
        /// This endpointing rule is based on both the last assistant message and the current customer message as they are speaking.<br/>
        /// Flow:<br/>
        /// - Assistant speaks<br/>
        /// - Customer starts speaking<br/>
        /// - Customer transcription comes in<br/>
        /// - This rule is evaluated on the last assistant message and the current customer transcription<br/>
        /// - If assistant message matches `assistantRegex` AND customer message matches `customerRegex`, the endpointing timeout is set to `timeoutSeconds`<br/>
        /// Usage:<br/>
        /// - If you want to wait longer while customer is speaking numbers, you can set a longer timeout.
        /// </param>
        /// <param name="assistantRegexOptions">
        /// These are the options for the assistant's message regex match. Defaults to all disabled.<br/>
        /// @default []
        /// </param>
        /// <param name="customerRegexOptions">
        /// These are the options for the customer's message regex match. Defaults to all disabled.<br/>
        /// @default []
        /// </param>
        public BothCustomEndpointingRule(
            string assistantRegex,
            string customerRegex,
            double timeoutSeconds,
            global::G.BothCustomEndpointingRuleType type,
            global::System.Collections.Generic.IList<global::G.RegexOption>? assistantRegexOptions,
            global::System.Collections.Generic.IList<global::G.RegexOption>? customerRegexOptions)
        {
            this.Type = type;
            this.AssistantRegex = assistantRegex ?? throw new global::System.ArgumentNullException(nameof(assistantRegex));
            this.AssistantRegexOptions = assistantRegexOptions;
            this.CustomerRegex = customerRegex ?? throw new global::System.ArgumentNullException(nameof(customerRegex));
            this.CustomerRegexOptions = customerRegexOptions;
            this.TimeoutSeconds = timeoutSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BothCustomEndpointingRule" /> class.
        /// </summary>
        public BothCustomEndpointingRule()
        {
        }
    }
}