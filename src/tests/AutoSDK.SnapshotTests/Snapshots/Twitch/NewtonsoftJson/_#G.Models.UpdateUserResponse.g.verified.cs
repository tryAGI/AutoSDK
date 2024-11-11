//HintName: G.Models.UpdateUserResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateUserResponse
    {
        /// <summary>
        /// A list contains the single user that you updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.User> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list contains the single user that you updated.
        /// </param>
        public UpdateUserResponse(
            global::System.Collections.Generic.IList<global::G.User> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserResponse" /> class.
        /// </summary>
        public UpdateUserResponse()
        {
        }
    }
}