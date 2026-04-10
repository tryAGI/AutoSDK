//HintName: G.Models.UpdateChatMetadataRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateChatMetadataRequest
    {
        /// <summary>
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the chat. Not used for processing. You can later get this field from the chat object. Size limited to 50kB max.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Data storage setting for this chat. Overrides the agent's default setting. "everything" stores all data, "basic_attributes_only" stores only metadata. Cannot be downgraded from more restrictive to less restrictive settings.<br/>
        /// Example: everything
        /// </summary>
        /// <example>everything</example>
        [global::Newtonsoft.Json.JsonProperty("data_storage_setting")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpdateChatMetadataRequestDataStorageSettingJsonConverter))]
        public global::G.UpdateChatMetadataRequestDataStorageSetting? DataStorageSetting { get; set; }

        /// <summary>
        /// Override dynamic varaibles represented as key-value pairs of strings. Setting this will override or add the dynamic variables set in the agent during the call. Only need to set the delta where you want to override, no need to set the entire dynamic variables object. Setting this to null will remove any existing override.<br/>
        /// Example: {"additional_discount":"15%"}
        /// </summary>
        /// <example>{"additional_discount":"15%"}</example>
        [global::Newtonsoft.Json.JsonProperty("override_dynamic_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? OverrideDynamicVariables { get; set; }

        /// <summary>
        /// Custom attributes for the chat<br/>
        /// Example: {"custom_attribute_1":"value1","custom_attribute_2":"value2"}
        /// </summary>
        /// <example>{"custom_attribute_1":"value1","custom_attribute_2":"value2"}</example>
        [global::Newtonsoft.Json.JsonProperty("custom_attributes")]
        public object? CustomAttributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChatMetadataRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// An arbitrary object for storage purpose only. You can put anything here like your internal customer id associated with the chat. Not used for processing. You can later get this field from the chat object. Size limited to 50kB max.
        /// </param>
        /// <param name="dataStorageSetting">
        /// Data storage setting for this chat. Overrides the agent's default setting. "everything" stores all data, "basic_attributes_only" stores only metadata. Cannot be downgraded from more restrictive to less restrictive settings.<br/>
        /// Example: everything
        /// </param>
        /// <param name="overrideDynamicVariables">
        /// Override dynamic varaibles represented as key-value pairs of strings. Setting this will override or add the dynamic variables set in the agent during the call. Only need to set the delta where you want to override, no need to set the entire dynamic variables object. Setting this to null will remove any existing override.<br/>
        /// Example: {"additional_discount":"15%"}
        /// </param>
        /// <param name="customAttributes">
        /// Custom attributes for the chat<br/>
        /// Example: {"custom_attribute_1":"value1","custom_attribute_2":"value2"}
        /// </param>
        public UpdateChatMetadataRequest(
            object? metadata,
            global::G.UpdateChatMetadataRequestDataStorageSetting? dataStorageSetting,
            global::System.Collections.Generic.Dictionary<string, string>? overrideDynamicVariables,
            object? customAttributes)
        {
            this.Metadata = metadata;
            this.DataStorageSetting = dataStorageSetting;
            this.OverrideDynamicVariables = overrideDynamicVariables;
            this.CustomAttributes = customAttributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChatMetadataRequest" /> class.
        /// </summary>
        public UpdateChatMetadataRequest()
        {
        }
    }
}