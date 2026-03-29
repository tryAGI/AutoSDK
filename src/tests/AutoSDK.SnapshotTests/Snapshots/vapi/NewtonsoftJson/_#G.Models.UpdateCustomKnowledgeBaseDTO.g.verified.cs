//HintName: G.Models.UpdateCustomKnowledgeBaseDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCustomKnowledgeBaseDTO
    {
        /// <summary>
        /// This is where the knowledge base request will be sent.<br/>
        /// Request Example:<br/>
        /// POST https://{server.url}<br/>
        /// Content-Type: application/json<br/>
        /// {<br/>
        ///   "messsage": {<br/>
        ///     "type": "knowledge-base-request",<br/>
        ///     "messages": [<br/>
        ///       {<br/>
        ///         "role": "user",<br/>
        ///         "content": "Why is ocean blue?"<br/>
        ///       }<br/>
        ///     ],<br/>
        ///     ...other metadata about the call...<br/>
        ///   }<br/>
        /// }<br/>
        /// Response Expected:<br/>
        /// ```<br/>
        /// {<br/>
        ///   "message": {<br/>
        ///      "role": "assistant",<br/>
        ///      "content": "The ocean is blue because water absorbs everything but blue.",<br/>
        ///   }, // YOU CAN RETURN THE EXACT RESPONSE TO SPEAK<br/>
        ///   "documents": [<br/>
        ///     {<br/>
        ///       "content": "The ocean is blue primarily because water absorbs colors in the red part of the light spectrum and scatters the blue light, making it more visible to our eyes.",<br/>
        ///       "similarity": 1<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "content": "Blue light is scattered more by the water molecules than other colors, enhancing the blue appearance of the ocean.",<br/>
        ///       "similarity": .5<br/>
        ///     }<br/>
        ///   ] // OR, YOU CAN RETURN AN ARRAY OF DOCUMENTS THAT WILL BE SENT TO THE MODEL<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server")]
        public global::G.Server? Server { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomKnowledgeBaseDTO" /> class.
        /// </summary>
        /// <param name="server">
        /// This is where the knowledge base request will be sent.<br/>
        /// Request Example:<br/>
        /// POST https://{server.url}<br/>
        /// Content-Type: application/json<br/>
        /// {<br/>
        ///   "messsage": {<br/>
        ///     "type": "knowledge-base-request",<br/>
        ///     "messages": [<br/>
        ///       {<br/>
        ///         "role": "user",<br/>
        ///         "content": "Why is ocean blue?"<br/>
        ///       }<br/>
        ///     ],<br/>
        ///     ...other metadata about the call...<br/>
        ///   }<br/>
        /// }<br/>
        /// Response Expected:<br/>
        /// ```<br/>
        /// {<br/>
        ///   "message": {<br/>
        ///      "role": "assistant",<br/>
        ///      "content": "The ocean is blue because water absorbs everything but blue.",<br/>
        ///   }, // YOU CAN RETURN THE EXACT RESPONSE TO SPEAK<br/>
        ///   "documents": [<br/>
        ///     {<br/>
        ///       "content": "The ocean is blue primarily because water absorbs colors in the red part of the light spectrum and scatters the blue light, making it more visible to our eyes.",<br/>
        ///       "similarity": 1<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "content": "Blue light is scattered more by the water molecules than other colors, enhancing the blue appearance of the ocean.",<br/>
        ///       "similarity": .5<br/>
        ///     }<br/>
        ///   ] // OR, YOU CAN RETURN AN ARRAY OF DOCUMENTS THAT WILL BE SENT TO THE MODEL<br/>
        /// }<br/>
        /// ```
        /// </param>
        public UpdateCustomKnowledgeBaseDTO(
            global::G.Server? server)
        {
            this.Server = server;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomKnowledgeBaseDTO" /> class.
        /// </summary>
        public UpdateCustomKnowledgeBaseDTO()
        {
        }
    }
}