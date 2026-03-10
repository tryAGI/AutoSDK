//HintName: G.Models.ListStaffParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListStaffParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("list_kwargs")]
        public object? ListKwargs { get; set; }

        /// <summary>
        /// Default Value: list_staff
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListStaffParams" /> class.
        /// </summary>
        /// <param name="listKwargs"></param>
        /// <param name="smbToolType">
        /// Default Value: list_staff
        /// </param>
        public ListStaffParams(
            object? listKwargs,
            string? smbToolType)
        {
            this.ListKwargs = listKwargs;
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListStaffParams" /> class.
        /// </summary>
        public ListStaffParams()
        {
        }
    }
}