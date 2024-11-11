//HintName: G.Models.OrganizationCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create organization schema.
    /// </summary>
    public sealed partial class OrganizationCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_personal", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPersonal { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreate" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="isPersonal"></param>
        public OrganizationCreate(
            string displayName,
            bool isPersonal)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.IsPersonal = isPersonal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreate" /> class.
        /// </summary>
        public OrganizationCreate()
        {
        }
    }
}