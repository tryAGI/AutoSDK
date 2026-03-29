//HintName: G.Models.ListOrganizationPeopleData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListOrganizationPeopleData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items")]
        public global::System.Collections.Generic.IList<global::G.OrganizationPeople>? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationPeopleData" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="totalCount"></param>
        public ListOrganizationPeopleData(
            global::System.Collections.Generic.IList<global::G.OrganizationPeople>? items,
            int? totalCount)
        {
            this.Items = items;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationPeopleData" /> class.
        /// </summary>
        public ListOrganizationPeopleData()
        {
        }
    }
}