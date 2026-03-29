//HintName: G.Models.RoleName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RoleName
    {
        /// <summary>
        /// The name of the role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("roleName", Required = global::Newtonsoft.Json.Required.Always)]
        public string RoleName1 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleName" /> class.
        /// </summary>
        /// <param name="roleName1">
        /// The name of the role.
        /// </param>
        public RoleName(
            string roleName1)
        {
            this.RoleName1 = roleName1 ?? throw new global::System.ArgumentNullException(nameof(roleName1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleName" /> class.
        /// </summary>
        public RoleName()
        {
        }
    }
}