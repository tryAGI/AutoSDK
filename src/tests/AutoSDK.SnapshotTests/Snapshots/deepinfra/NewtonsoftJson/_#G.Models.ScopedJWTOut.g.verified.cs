//HintName: G.Models.ScopedJWTOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScopedJWTOut
    {
        /// <summary>
        /// The newly minted scoped JWT ready for use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedJWTOut" /> class.
        /// </summary>
        /// <param name="token">
        /// The newly minted scoped JWT ready for use
        /// </param>
        public ScopedJWTOut(
            string token)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedJWTOut" /> class.
        /// </summary>
        public ScopedJWTOut()
        {
        }
    }
}