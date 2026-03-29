//HintName: G.Models.EnvironmentsDeleteEnvironmentResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsDeleteEnvironmentResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorCode", Required = global::Newtonsoft.Json.Required.Always)]
        public string ErrorCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsDeleteEnvironmentResponse3" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        public EnvironmentsDeleteEnvironmentResponse3(
            string errorCode,
            string message)
        {
            this.ErrorCode = errorCode ?? throw new global::System.ArgumentNullException(nameof(errorCode));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsDeleteEnvironmentResponse3" /> class.
        /// </summary>
        public EnvironmentsDeleteEnvironmentResponse3()
        {
        }
    }
}