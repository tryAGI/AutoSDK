//HintName: G.Models.ApiProjectsExportsConvertCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProjectsExportsConvertCreateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("converted_format")]
        public int? ConvertedFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("export_type")]
        public string? ExportType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsExportsConvertCreateResponse" /> class.
        /// </summary>
        /// <param name="convertedFormat"></param>
        /// <param name="exportType"></param>
        public ApiProjectsExportsConvertCreateResponse(
            int? convertedFormat,
            string? exportType)
        {
            this.ConvertedFormat = convertedFormat;
            this.ExportType = exportType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProjectsExportsConvertCreateResponse" /> class.
        /// </summary>
        public ApiProjectsExportsConvertCreateResponse()
        {
        }
    }
}