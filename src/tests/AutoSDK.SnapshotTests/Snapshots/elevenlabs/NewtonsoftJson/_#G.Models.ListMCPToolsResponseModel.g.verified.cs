//HintName: G.Models.ListMCPToolsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for testing tools available on an MCP server.<br/>
    /// Example: {"success":true,"tools":[{"description":"Gets tomorrow\u0027s forecasted weather conditions for a location.","inputSchema":{"properties":{"latitude":{"description":"Latitude","type":"string"},"longitude":{"description":"Longitude","type":"string"}},"required":["latitude","longitude"],"type":"object"},"name":"weather_by_zapier_get_tomorrow"},{"description":"Description of tool2","name":"tool2"}]}
    /// </summary>
    public sealed partial class ListMCPToolsResponseModel
    {
        /// <summary>
        /// Indicates if the operation was successful.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// A list of tools available on the MCP server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Tool> Tools { get; set; } = default!;

        /// <summary>
        /// Error message if the operation was not successful.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMCPToolsResponseModel" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates if the operation was successful.
        /// </param>
        /// <param name="tools">
        /// A list of tools available on the MCP server.
        /// </param>
        /// <param name="errorMessage">
        /// Error message if the operation was not successful.
        /// </param>
        public ListMCPToolsResponseModel(
            bool success,
            global::System.Collections.Generic.IList<global::G.Tool> tools,
            string? errorMessage)
        {
            this.Success = success;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMCPToolsResponseModel" /> class.
        /// </summary>
        public ListMCPToolsResponseModel()
        {
        }
    }
}