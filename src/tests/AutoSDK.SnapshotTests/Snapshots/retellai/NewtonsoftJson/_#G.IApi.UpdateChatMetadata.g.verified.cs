//HintName: G.IApi.UpdateChatMetadata.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Update metadata and sensitive data storage settings for an existing chat.
        /// </summary>
        /// <param name="chatId">
        /// Example: chat_98c1a2157aa0559144d67bb0729
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatResponse> UpdateChatMetadataAsync(
            string chatId,

            global::G.UpdateChatMetadataRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update metadata and sensitive data storage settings for an existing chat.
        /// </summary>
        /// <param name="chatId">
        /// Example: chat_98c1a2157aa0559144d67bb0729
        /// </param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatResponse> UpdateChatMetadataAsync(
            string chatId,
            object? metadata = default,
            global::G.UpdateChatMetadataRequestDataStorageSetting? dataStorageSetting = default,
            global::System.Collections.Generic.Dictionary<string, string>? overrideDynamicVariables = default,
            object? customAttributes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}