//HintName: G.Models.ApiProjectsAwsCustomFunctionRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsAwsCustomFunctionRetrieveResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Deployment status of the Lambda function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiProjectsAwsCustomFunctionRetrieveResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsAwsCustomFunctionRetrieveResponse" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="status">
        /// Deployment status of the Lambda function.
        /// </param>
        public ApiProjectsAwsCustomFunctionRetrieveResponse(
            string code,
            global::G.ApiProjectsAwsCustomFunctionRetrieveResponseStatus status)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsAwsCustomFunctionRetrieveResponse" /> class.
        /// </summary>
        public ApiProjectsAwsCustomFunctionRetrieveResponse()
        {
        }
    }
}