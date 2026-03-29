//HintName: G.Models.GetEnvVarResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEnvVarResponse
    {
        /// <summary>
        /// A list of env_var objects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objects", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EnvVar> Objects { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEnvVarResponse" /> class.
        /// </summary>
        /// <param name="objects">
        /// A list of env_var objects
        /// </param>
        public GetEnvVarResponse(
            global::System.Collections.Generic.IList<global::G.EnvVar> objects)
        {
            this.Objects = objects ?? throw new global::System.ArgumentNullException(nameof(objects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEnvVarResponse" /> class.
        /// </summary>
        public GetEnvVarResponse()
        {
        }
    }
}