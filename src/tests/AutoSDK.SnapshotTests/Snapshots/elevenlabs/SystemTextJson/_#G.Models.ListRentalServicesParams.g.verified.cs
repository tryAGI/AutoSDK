//HintName: G.Models.ListRentalServicesParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListRentalServicesParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("list_kwargs")]
        public object? ListKwargs { get; set; }

        /// <summary>
        /// Default Value: list_rental_services
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRentalServicesParams" /> class.
        /// </summary>
        /// <param name="listKwargs"></param>
        /// <param name="smbToolType">
        /// Default Value: list_rental_services
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListRentalServicesParams(
            object? listKwargs,
            string? smbToolType)
        {
            this.ListKwargs = listKwargs;
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRentalServicesParams" /> class.
        /// </summary>
        public ListRentalServicesParams()
        {
        }
    }
}