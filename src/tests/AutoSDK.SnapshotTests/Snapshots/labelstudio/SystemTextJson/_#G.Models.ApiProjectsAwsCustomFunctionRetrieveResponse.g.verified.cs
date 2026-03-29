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
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Deployment status of the Lambda function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApiProjectsAwsCustomFunctionRetrieveResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApiProjectsAwsCustomFunctionRetrieveResponseStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsAwsCustomFunctionRetrieveResponse" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="status">
        /// Deployment status of the Lambda function.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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