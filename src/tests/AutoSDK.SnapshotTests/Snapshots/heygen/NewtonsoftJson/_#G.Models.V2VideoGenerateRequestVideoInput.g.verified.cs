﻿//HintName: G.Models.V2VideoGenerateRequestVideoInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class V2VideoGenerateRequestVideoInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character")]
        public global::G.V2VideoGenerateRequestVideoInputCharacter? Character { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.V2VideoGenerateRequestVideoInputVoice? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequestVideoInput" /> class.
        /// </summary>
        /// <param name="character"></param>
        /// <param name="voice"></param>
        public V2VideoGenerateRequestVideoInput(
            global::G.V2VideoGenerateRequestVideoInputCharacter? character,
            global::G.V2VideoGenerateRequestVideoInputVoice? voice)
        {
            this.Character = character;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2VideoGenerateRequestVideoInput" /> class.
        /// </summary>
        public V2VideoGenerateRequestVideoInput()
        {
        }
    }
}