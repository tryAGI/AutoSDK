//HintName: G.Models.CreateRealtimeTemporaryTokenParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRealtimeTemporaryTokenParams
    {
        /// <summary>
        /// The amount of time until the token expires in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_in", Required = global::Newtonsoft.Json.Required.Always)]
        public int ExpiresIn { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeTemporaryTokenParams" /> class.
        /// </summary>
        /// <param name="expiresIn">
        /// The amount of time until the token expires in seconds
        /// </param>
        public CreateRealtimeTemporaryTokenParams(
            int expiresIn)
        {
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRealtimeTemporaryTokenParams" /> class.
        /// </summary>
        public CreateRealtimeTemporaryTokenParams()
        {
        }
    }
}