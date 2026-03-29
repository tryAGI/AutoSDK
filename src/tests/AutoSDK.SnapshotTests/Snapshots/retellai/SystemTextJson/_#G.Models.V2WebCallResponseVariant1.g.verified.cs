//HintName: G.Models.V2WebCallResponseVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2WebCallResponseVariant1
    {
        /// <summary>
        /// Type of the call. Used to distinguish between web call and phone call.<br/>
        /// Example: web_call
        /// </summary>
        /// <example>web_call</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.V2WebCallResponseVariant1CallTypeJsonConverter))]
        public global::G.V2WebCallResponseVariant1CallType CallType { get; set; }

        /// <summary>
        /// Access token to enter the web call room. This needs to be passed to your frontend to join the call.<br/>
        /// Example: eyJhbGciOiJIUzI1NiJ9.eyJ2aWRlbyI6eyJyb29tSm9p
        /// </summary>
        /// <example>eyJhbGciOiJIUzI1NiJ9.eyJ2aWRlbyI6eyJyb29tSm9p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2WebCallResponseVariant1" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// Access token to enter the web call room. This needs to be passed to your frontend to join the call.<br/>
        /// Example: eyJhbGciOiJIUzI1NiJ9.eyJ2aWRlbyI6eyJyb29tSm9p
        /// </param>
        /// <param name="callType">
        /// Type of the call. Used to distinguish between web call and phone call.<br/>
        /// Example: web_call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2WebCallResponseVariant1(
            string accessToken,
            global::G.V2WebCallResponseVariant1CallType callType)
        {
            this.CallType = callType;
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2WebCallResponseVariant1" /> class.
        /// </summary>
        public V2WebCallResponseVariant1()
        {
        }
    }
}