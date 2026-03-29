//HintName: G.Models.AWSCustomFunctionUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for updating AWS Lambda custom metric function.
    /// </summary>
    public sealed partial class AWSCustomFunctionUpdateRequest
    {
        /// <summary>
        /// The Python code for the custom metric function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// The AWS region for the Lambda function. Uses default if not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// The AWS IAM role ARN for the Lambda function. Uses default if not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSCustomFunctionUpdateRequest" /> class.
        /// </summary>
        /// <param name="code">
        /// The Python code for the custom metric function.
        /// </param>
        /// <param name="region">
        /// The AWS region for the Lambda function. Uses default if not provided.
        /// </param>
        /// <param name="role">
        /// The AWS IAM role ARN for the Lambda function. Uses default if not provided.
        /// </param>
        public AWSCustomFunctionUpdateRequest(
            string code,
            string? region,
            string? role)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Region = region;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AWSCustomFunctionUpdateRequest" /> class.
        /// </summary>
        public AWSCustomFunctionUpdateRequest()
        {
        }
    }
}