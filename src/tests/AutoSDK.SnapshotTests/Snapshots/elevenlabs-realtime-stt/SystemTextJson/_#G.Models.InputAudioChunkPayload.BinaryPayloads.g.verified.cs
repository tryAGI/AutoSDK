//HintName: G.Models.InputAudioChunkPayload.BinaryPayloads.g.cs

#nullable enable

namespace G
{
    public sealed partial class InputAudioChunkPayload
    {
        /// <summary>
        /// Gets the decoded bytes for <see cref="AudioBase64" />.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonIgnore]
        public global::System.ReadOnlyMemory<byte> AudioBase64Bytes => AudioBase64 is null
            ? default
            : global::System.Convert.FromBase64String(AudioBase64);
    }
}