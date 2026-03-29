//HintName: G.Models.PromptAwsInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAwsInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"aws"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "aws";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aws", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptAwsInvocationParametersContent Aws { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAwsInvocationParameters" /> class.
        /// </summary>
        /// <param name="aws"></param>
        /// <param name="type"></param>
        public PromptAwsInvocationParameters(
            global::G.PromptAwsInvocationParametersContent aws,
            string type = "aws")
        {
            this.Type = type;
            this.Aws = aws ?? throw new global::System.ArgumentNullException(nameof(aws));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAwsInvocationParameters" /> class.
        /// </summary>
        public PromptAwsInvocationParameters()
        {
        }
    }
}