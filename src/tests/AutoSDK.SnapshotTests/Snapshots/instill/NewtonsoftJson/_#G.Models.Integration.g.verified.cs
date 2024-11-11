//HintName: G.Models.Integration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Integration contains the parameters to create a connection between<br/>
    /// components and 3rd party apps.
    /// </summary>
    public sealed partial class Integration
    {
        /// <summary>
        /// UUID-formatted unique identifier. It references a component definition.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Identifier of the integration, which references a component definition.<br/>
        /// Components with that definition ID will be able to use the connections<br/>
        /// produced by this integration.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Title, reflects the app name.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Short description of the integrated app.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Integrated app vendor name.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vendor")]
        public string? Vendor { get; set; }

        /// <summary>
        /// Integration icon. This is a path that's relative to the root of<br/>
        /// the component implementation and that allows frontend applications to pull<br/>
        /// and locate the icons.<br/>
        /// See the `icon` field in the `ComponentDefinition` entity for more<br/>
        /// information.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Reference to the vendor's documentation to expand the integration details.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("helpLink")]
        public global::G.Link? HelpLink { get; set; }

        /// <summary>
        /// The connection setup field definitions. Each integration will require<br/>
        /// different data to connect to the 3rd party app.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("setupSchema")]
        public object? SetupSchema { get; set; }

        /// <summary>
        /// Configuration parameters required for the OAuth setup flow. This field<br/>
        /// will be present only if the integration supports OAuth 2.0.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("oAuthConfig")]
        public global::G.OAuthConfig? OAuthConfig { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("view")]
        public global::G.PipelineV1betaView? View { get; set; }

        /// <summary>
        /// Schemas defines the supported schemas for the connection setup.<br/>
        /// We haven't found a case for a schema that changes on the connection method<br/>
        /// (components don't care about how the connection was built), so the schema<br/>
        /// will be provided in the setupSchema field and the OAuth support and<br/>
        /// configuration will be provided in oAuthConfig.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schemas")]
        public global::System.Collections.Generic.IList<global::G.SetupSchema>? Schemas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Integration" /> class.
        /// </summary>
        /// <param name="uid">
        /// UUID-formatted unique identifier. It references a component definition.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Identifier of the integration, which references a component definition.<br/>
        /// Components with that definition ID will be able to use the connections<br/>
        /// produced by this integration.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="title">
        /// Title, reflects the app name.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Short description of the integrated app.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="vendor">
        /// Integrated app vendor name.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="icon">
        /// Integration icon. This is a path that's relative to the root of<br/>
        /// the component implementation and that allows frontend applications to pull<br/>
        /// and locate the icons.<br/>
        /// See the `icon` field in the `ComponentDefinition` entity for more<br/>
        /// information.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="helpLink">
        /// Reference to the vendor's documentation to expand the integration details.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="setupSchema">
        /// The connection setup field definitions. Each integration will require<br/>
        /// different data to connect to the 3rd party app.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="oAuthConfig">
        /// Configuration parameters required for the OAuth setup flow. This field<br/>
        /// will be present only if the integration supports OAuth 2.0.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="view">
        /// Included only in responses
        /// </param>
        /// <param name="schemas">
        /// Schemas defines the supported schemas for the connection setup.<br/>
        /// We haven't found a case for a schema that changes on the connection method<br/>
        /// (components don't care about how the connection was built), so the schema<br/>
        /// will be provided in the setupSchema field and the OAuth support and<br/>
        /// configuration will be provided in oAuthConfig.<br/>
        /// Included only in responses
        /// </param>
        public Integration(
            string? uid,
            string? id,
            string? title,
            string? description,
            string? vendor,
            string? icon,
            global::G.Link? helpLink,
            object? setupSchema,
            global::G.OAuthConfig? oAuthConfig,
            global::G.PipelineV1betaView? view,
            global::System.Collections.Generic.IList<global::G.SetupSchema>? schemas)
        {
            this.Uid = uid;
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Vendor = vendor;
            this.Icon = icon;
            this.HelpLink = helpLink;
            this.SetupSchema = setupSchema;
            this.OAuthConfig = oAuthConfig;
            this.View = view;
            this.Schemas = schemas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Integration" /> class.
        /// </summary>
        public Integration()
        {
        }
    }
}