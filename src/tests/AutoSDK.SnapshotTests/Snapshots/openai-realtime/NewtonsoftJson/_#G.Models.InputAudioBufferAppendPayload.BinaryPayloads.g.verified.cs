//HintName: G.Models.InputAudioBufferAppendPayload.BinaryPayloads.g.cs

#nullable enable

namespace G
{
    public sealed partial class InputAudioBufferAppendPayload
    {
        /// <summary>
        /// Gets the decoded bytes for <see cref="Audio" />.
        /// </summary>
        [global::Newtonsoft.Json.JsonIgnore]
        public global::System.ReadOnlyMemory<byte> AudioBytes => Audio is null
            ? default
            : global::System.Convert.FromBase64String(Audio);
    }
}